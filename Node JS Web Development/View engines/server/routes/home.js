'use strict';
let pages = ['Smartphones', 'Tablets', 'Wearables'];

module.exports = function(req, res){
    res.render('home', {pages: pages});
}