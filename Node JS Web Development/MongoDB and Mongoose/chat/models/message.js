var mongoose = require('mongoose');
require('./user');

var User = mongoose.model('User');
var messageSchema = new mongoose.Schema({
    from: { type: String, require: true },
    to: { type: String, require: true },
    text: { type: String, require: true },
});

messageSchema.statics.existUsers = function (message, callback) {
    User.find()
        .or([{username: message.from}, 
            {username: message.to}])
        .exec(function (err, users) {
            if (err) throw err;
            if (users.length !== 2) {
                throw {
                    message: 'One or two users in message not exists'
                };
            }

            callback();
        });
};

mongoose.model('Message', messageSchema);