const {Router} = require('express');

const router = Router();

router.get('/',(req,res)=>{
    const data={
        "name": "itsai",
        "website": "feis.com"
    }
    res.json(data);
});

module.exports= router;