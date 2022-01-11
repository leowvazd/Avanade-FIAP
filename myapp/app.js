const express = require('express')
const app = express()
const port = 3000

app.get('/', (req, res) => res.send('Hello World Express Application Generator!'))

app.listen(port, () => console.log('Exemplo app executando na porta ${port}!'))