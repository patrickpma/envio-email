const express = require('express')
const nodemailer = require('nodemailer')
const app = express()
const port = 3000

app.get('/', (req, res) => {
    const transporter = nodemailer.createTransport({
        host: "localhost", //Host
        port: 25, // Port 
        secure: false
    });

    let mailOptions = {
        from: "patrick.oliveira@remetente.com.br", // sender address
        to: "patrick.oliveira@destinatario.com.br", // list of receivers
        subject: "Teste nodemailer", // Subject line
        text: "TESTE NODEMAILER", // plain text body
        html: ""
    };

    /**
     * send mail with defined transport object
     */
    transporter.sendMail(mailOptions,
        (error, info) => {
            res.send(error);
            res.send(info);
        });
})

app.listen(port, () => {
    console.log(`Example app listening on port ${port}`)
})