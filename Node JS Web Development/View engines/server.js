'use strict';
let express = require('express'),
    jade = require('jade'),
    routes = require('./server/routes');
    
let app = express();
let port = 1234;

app.set('port', process.env.PORT || port);
app.set('views', __dirname + '/server/views');
app.set('view engine', 'jade');
app.use(express.static(__dirname + '/server/public'));

app.get('/', routes.index);

app.listen(app.get('port'), function(){
    console.log("Server running on port: " + app.get('port'));
})