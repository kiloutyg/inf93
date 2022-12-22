import express, { Request, Response } from 'express';

const app: express.Application = express();
const PORT: number = 8080;

app.listen(
    PORT,
    () => console.log(`Server listening on port http://localhost:${PORT}`)
);

app.get('/tshirt', (req: Request, res: Response) => {
    res.status(200).send({
        "name": "T-shirt",
        "price": "10.00",
        "size": "M",
        "color": "red"
    })
});

app.get('/sweater', (req: Request, res: Response) => {
    res.status(200).send({
        "name": "Sweater",
        "price": "20.00",
        "size": "L",
        "color": "blue"
    })
});

app.post('tshirt/:id', (req: Request, res: Response) => {
    
    const id: string = req.params.id;
    const logo: string = req.body.logo;
    
    if (!logo) { 
        res.status(418).send({ message: 'We need a logo!' })
    }
    
    res.send({
        tshirt: `tshirt with your ${logo} and ID of ${id}`,
    });
});
