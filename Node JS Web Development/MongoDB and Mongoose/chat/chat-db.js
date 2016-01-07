var mongoose = require('mongoose');
require('./models');
var User = mongoose.model('User');
var Message = mongoose.model('Message');

var db = {
    registerUser: function registerUser(newUser, callback) {
        var escapedUser = {
            username: escapeHtml(newUser.username),
            password: escapeHtml(newUser.password)
        }

        var user = new User(escapedUser);
        User.uniqueUsername(escapedUser.username, function (err) {
            if (err) {
                throw err;
            }
            else {
                user.save(function (err) {
                    if (err) {
                        throw err;
                    }
                    
                    callback();
                });
            }
        });
    },
    sendMessage: function sendMessage(newMessage, callback) {
        var escapedMessage = {
            from: escapeHtml(newMessage.from),
            to: escapeHtml(newMessage.to),
            text: escapeHtml(newMessage.text)
        };

        var message = new Message(escapedMessage);
        Message.existUsers(escapedMessage, function (err) {
            if (err) {
                throw err;
            }
            else {
                message.save(function (err) {
                    if (err) {
                        throw err;
                    }
                    
                    callback();
                });
            }
        });
    },
    getMessages: function getMessages(callback) {
        Message.find({}).exec(function (err, messages) {
            if (err) {
                throw err;
            }

            callback(messages);
        });
    }
};

function escapeHtml(value) {
    return value.toString().
        replace('<', '&lt;').
        replace('>', '&gt;').
        replace('"', '&quot;');
}

module.exports = db;