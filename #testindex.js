const app = require('express')();
const PORT = 8080;

app.get('/tshirt', (req,res) => {
    res.status(200).send('<h1>T-shirt</h1>');
});

app.get('/sweater', (req,res) => {
    res.status(200).send('<h1>Sweater</h1>');
});