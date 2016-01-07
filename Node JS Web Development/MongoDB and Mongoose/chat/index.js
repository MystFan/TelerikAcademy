var mongoose = require('mongoose');
var chatDb = require('./chat-db');
var fs = require('fs');

mongoose.connect('mongodb://localhost/ChatSystem');

require('./models');

var Message = mongoose.model('Message');
var User = mongoose.model('User');

chatDb.registerUser({ username: 'Niki', password: 'works' }, function () {
    console.log('Register succes!');
});

chatDb.registerUser({ username: 'Pesho', password: 'works' }, function () {
    chatDb.sendMessage({ from: 'Pesho', to: 'Niki', text: 'Chat works' }, function () {
        chatDb.getMessages(function (messages) {
            for (var index = 0; index < messages.length; index++) {
                console.log(`${messages[index].text}`);
            }
        });
    });
});

