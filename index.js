// server handles API, that informs if ESN PB office is opened or not
// actually if office copmuter is turned on
const port = 3003;
const express = require('express');
const bodyParser = require('body-parser');
var fs = require('fs');
const app = express();

const CONFIG_ENCODING = 'utf8';
const CONFIG_PATH = './config.json';

app.use(bodyParser.json());
app.use(function(req, res, next) {
  res.setHeader("Access-Control-Allow-Origin", "*");
  res.setHeader('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, DELETE');
  res.setHeader('Access-Control-Allow-Headers', 'X-Requested-With,content-type');
  res.setHeader('Access-Control-Allow-Credentials', true);
  res.setHeader('Content-Type', 'application/json');
  next();
});

app.get('/isofficeopened', (req, res) => {
  try {
    fs.readFile(CONFIG_PATH, CONFIG_ENCODING, function (err, data) {
	  if (err) {
        throw { message: err };
      }
      var config = JSON.parse(data);
	  var ip = req.headers['x-forwarded-for'] || req.connection.remoteAddress;
	  console.log('request from', ip)
      res.send(JSON.stringify(config));
    });
  }
  catch(ex) {
	console.log('error', ex.message);
	response.send('{ error: "' + ex.message + '"}');
  }
});

app.listen(port, (err) => {
  if (err) {
    return console.log('something bad happened', err);
  }

  console.log(`server is listening on ${port}`);
});
