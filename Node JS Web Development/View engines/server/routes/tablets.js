'use strict';
let pages = ['Smartphones', 'Tablets', 'Wearables'],
    fs = require('fs');

module.exports = function (req, res) {
    fs.readFile('server/data/tablets.json', function(err, content){
        let data = JSON.parse(content.toString());
        res.render('tablets', { tablets: data.tablets, pages: pages })
    });   
}