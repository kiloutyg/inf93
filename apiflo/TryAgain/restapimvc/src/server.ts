// console.log('hello ahbon');
import * as express from 'express';
import {Application, Response, Request} from 'express';

const app: Application = express();

app.get('/', (req: Request, res: Response) => {
    res.send('Hello ahbon!');
});

app.listen(3000, () => {
    console.log('TS Server is running on port 3000');
});