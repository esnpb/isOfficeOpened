using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IsOfficeOpenedConfigurator
{
    public partial class Form1 : Form
    {
        private const int HOUR_SCROLL_BIG_STEP = 1;
        private const int HOUR_SCROLL_SMALL_STEP = 1;
        private const int MINUTE_SCROLL_BIG_STEP = 5;
        private const int MINUTE_SCROLL_SMALL_STEP = 5;

        public class MyConfig
        {
            public DateTime OpenUntil { get; set; }
            public string ImagePath { get; set; }
            public bool IsOpened { get { return true; } }
        }

        public Form1()
        {
            InitializeComponent();
            DateTime currentDate = DateTime.Now;
            nudHourUntil.Value = currentDate.Hour;
            nudMinutesUntil.Value = currentDate.Minute;
        }

        private void chbIsApiOn_CheckedChanged(object sender, EventArgs e)
        {
            grbOpenedUntil.Enabled = grbOthers.Enabled = ((CheckBox)sender).Checked;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closeWindow();
        }


        public void closeWindow()
        {
            DateTime now = DateTime.Now;
            MyConfig config = new MyConfig()
            {
                OpenUntil = new DateTime(now.Year, now.Month, now.Day, (int)nudHourUntil.Value, (int)nudMinutesUntil.Value, 0),
                ImagePath = "",
            };
            // save
            SaveJson(config);
            // close
            this.Close();
        }

        public void SaveJson(MyConfig config)
        {
            string json = JsonConvert.SerializeObject(config);
            File.WriteAllText(@"./config.json", json);
        }

        private void nudHourUntil_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                closeWindow();
            }
        }

        private void ValueUp(NumericUpDown control, int count)
        {
            control.Value += count;
        }

        private void nudHourUntil_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                bool isHourCtrl = (sender == nudHourUntil);
                switch (e.Type)
                {
                    case ScrollEventType.LargeDecrement:
                        ValueUp(sender as NumericUpDown, isHourCtrl ? -HOUR_SCROLL_BIG_STEP : -MINUTE_SCROLL_BIG_STEP);
                        break;
                    case ScrollEventType.LargeIncrement:
                        ValueUp(sender as NumericUpDown, isHourCtrl ? HOUR_SCROLL_BIG_STEP : MINUTE_SCROLL_BIG_STEP);
                        break;
                    case ScrollEventType.SmallDecrement:
                        ValueUp(sender as NumericUpDown, isHourCtrl ? -HOUR_SCROLL_SMALL_STEP : -MINUTE_SCROLL_SMALL_STEP);
                        break;
                    case ScrollEventType.SmallIncrement:
                        ValueUp(sender as NumericUpDown, isHourCtrl ? HOUR_SCROLL_SMALL_STEP : MINUTE_SCROLL_SMALL_STEP);
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
