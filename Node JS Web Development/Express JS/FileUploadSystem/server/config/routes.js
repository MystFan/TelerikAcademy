var auth = require('./auth'),
    controllers = require('../controllers');

module.exports = function(app) {
    app.get('/register', controllers.users.getRegister);
    app.post('/register', controllers.users.postRegister);

    app.get('/login', controllers.users.getLogin);
    app.post('/login', auth.login);
    app.get('/logout', auth.isAuthenticated, auth.logout);
    
    app.get('/profile', controllers.users.getProfile);
    
    app.get('/upload', auth.isAuthenticated, controllers.files.getUpload);
    app.post('/upload', auth.isAuthenticated, controllers.files.postUpload);
    
    app.get('/download', auth.isAuthenticated, controllers.files.download);    
    
    app.get('/all-files', auth.isAuthenticated, controllers.files.getFiles);
    
    app.get('/', function(req, res){
        res.render('index', {currentUser: req.user});
    })

    app.get('*', function(req, res) {
        res.render('index', {currentUser: req.user});
    });
}