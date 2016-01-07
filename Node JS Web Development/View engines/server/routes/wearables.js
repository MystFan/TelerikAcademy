'use strict';
let pages = ['Smartphones', 'Tablets', 'Wearables'],
    fs = require('fs');

module.exports = function (req, res) {
    fs.readFile('server/data/wearables.json', function(err, content){
        let data = JSON.parse(content.toString());
        res.render('wearables', { wearables: data.wearables, pages: pages })
    });   
}