namespace IsOfficeOpenedConfigurator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbOpenedUntil = new System.Windows.Forms.GroupBox();
            this.nudMinutesUntil = new System.Windows.Forms.NumericUpDown();
            this.nudHourUntil = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbOthers = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.chbIsApiOn = new System.Windows.Forms.CheckBox();
            this.grbOpenedUntil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesUntil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourUntil)).BeginInit();
            this.grbOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbOpenedUntil
            // 
            this.grbOpenedUntil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbOpenedUntil.Controls.Add(this.nudMinutesUntil);
            this.grbOpenedUntil.Controls.Add(this.nudHourUntil);
            this.grbOpenedUntil.Controls.Add(this.label2);
            this.grbOpenedUntil.Controls.Add(this.label1);
            this.grbOpenedUntil.Location = new System.Drawing.Point(13, 35);
            this.grbOpenedUntil.Name = "grbOpenedUntil";
            this.grbOpenedUntil.Size = new System.Drawing.Size(290, 102);
            this.grbOpenedUntil.TabIndex = 0;
            this.grbOpenedUntil.TabStop = false;
            this.grbOpenedUntil.Text = "Czas otwarcia biura";
            // 
            // nudMinutesUntil
            // 
            this.nudMinutesUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudMinutesUntil.Location = new System.Drawing.Point(135, 44);
            this.nudMinutesUntil.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinutesUntil.Name = "nudMinutesUntil";
            this.nudMinutesUntil.Size = new System.Drawing.Size(60, 45);
            this.nudMinutesUntil.TabIndex = 5;
            this.nudMinutesUntil.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nudHourUntil_Scroll);
            this.nudMinutesUntil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudHourUntil_KeyDown);
            // 
            // nudHourUntil
            // 
            this.nudHourUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudHourUntil.Location = new System.Drawing.Point(37, 44);
            this.nudHourUntil.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHourUntil.Name = "nudHourUntil";
            this.nudHourUntil.Size = new System.Drawing.Size(60, 45);
            this.nudHourUntil.TabIndex = 0;
            this.nudHourUntil.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nudHourUntil_Scroll);
            this.nudHourUntil.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudHourUntil_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(103, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do której godziny chcesz zostać w biurze ESN PB?";
            // 
            // grbOthers
            // 
            this.grbOthers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbOthers.Controls.Add(this.checkBox1);
            this.grbOthers.Location = new System.Drawing.Point(13, 143);
            this.grbOthers.Name = "grbOthers";
            this.grbOthers.Size = new System.Drawing.Size(290, 100);
            this.grbOthers.TabIndex = 1;
            this.grbOthers.TabStop = false;
            this.grbOthers.Text = "Inne (nie działają)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(154, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Udostępniaj fotkę z kamery";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(228, 250);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "OK";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chbIsApiOn
            // 
            this.chbIsApiOn.AutoSize = true;
            this.chbIsApiOn.Checked = true;
            this.chbIsApiOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbIsApiOn.Location = new System.Drawing.Point(12, 12);
            this.chbIsApiOn.Name = "chbIsApiOn";
            this.chbIsApiOn.Size = new System.Drawing.Size(212, 17);
            this.chbIsApiOn.TabIndex = 4;
            this.chbIsApiOn.TabStop = false;
            this.chbIsApiOn.Text = "Udostępniaj poniższe info o stanie biura";
            this.chbIsApiOn.UseVisualStyleBackColor = true;
            this.chbIsApiOn.CheckedChanged += new System.EventHandler(this.chbIsApiOn_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 285);
            this.Controls.Add(this.chbIsApiOn);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grbOthers);
            this.Controls.Add(this.grbOpenedUntil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "\"Is ESN PB office opened\" config";
            this.grbOpenedUntil.ResumeLayout(false);
            this.grbOpenedUntil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesUntil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHourUntil)).EndInit();
            this.grbOthers.ResumeLayout(false);
            this.grbOthers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbOpenedUntil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbOthers;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chbIsApiOn;
        private System.Windows.Forms.NumericUpDown nudMinutesUntil;
        private System.Windows.Forms.NumericUpDown nudHourUntil;
    }
}

