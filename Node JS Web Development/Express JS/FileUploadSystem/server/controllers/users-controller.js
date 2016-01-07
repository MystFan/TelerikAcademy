var encryption = require('../utilities/encryption');
var users = require('../data/users');
var CONTROLLER_NAME = 'users';
var uploading = require('../utilities/uploading');
var files = require('../data/files');

module.exports = {
    postRegister: function (req, res, next) {
        var newUserData = req.body;

        if (newUserData.confirmPassword !== newUserData.password) {
            req.session.error = 'Password and confirm password do not match';
            res.redirect('/register');
        }
        else {
            newUserData.salt = encryption.generateSalt();
            newUserData.hashPass = encryption.generateHashedPassword(newUserData.salt, newUserData.password);
            users.create(newUserData, function (err, user) {
                if (err) {
                    console.log('Failed to register new user: ' + err);
                    return;
                }

                uploading.createDir('/', user.username);

                req.logIn(user, function (err) {
                    if (err) {
                        res.status(400);
                        return res.send({ reason: err.toString() });
                    }
                    else {
                        res.redirect('/');
                    }
                })
            })
        }
    },
    getRegister: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/register');
    },
    getLogin: function (req, res) {
        res.render(CONTROLLER_NAME + '/login');
    },
    getProfile: function (req, res, next) {
        files.getUserFiles(req.user._id, function (files) {
            res.render('users/profile', {currentUser: req.user,  files: files });
        })
    }
}