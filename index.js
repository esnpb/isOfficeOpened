// server handles API, that informs if ESN PB office is opened or not
// actually if office copmuter is turned on
const port = 2137;
const express = require('express');
const app = express();

app.get('/', (request, response) => {
  response.send('Hello from Express!');
});

app.get('/isofficeopened', (request, response) => {
  response.send('yup');
});

app.listen(port, (err) => {
  if (err) {
    return console.log('something bad happened', err);
  }

  console.log(`server is listening on ${port}`);
});
