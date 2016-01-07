'use strict';
let pages = ['Smart phones', 'Tablets', 'Wearables'];

module.exports = function(req, res){
    console.log('index');
    res.render('layout', {pages: pages});
}