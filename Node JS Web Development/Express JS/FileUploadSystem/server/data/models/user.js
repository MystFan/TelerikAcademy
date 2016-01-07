var mongoose = require('mongoose'),
    encryption = require('../../utilities/encryption');
var User;

module.exports = {
    init: function () {
        var userSchema = new mongoose.Schema({
            username: { type: String, require: '{PATH} is required', unique: true },
            salt: String,
            hashPass: String,
            points: Number
        });

        userSchema.method({
            authenticate: function (password) {
                if (encryption.generateHashedPassword(this.salt, password) === this.hashPass) {
                    return true;
                }
                else {
                    return false;
                }
            }
        });

        User = mongoose.model('User', userSchema);
    },
    seedInitialUsers: function () {
        User.find({}).exec(function (err, collection) {
            if (err) {
                console.log('Cannot find users: ' + err);
                return;
            }

            if (collection.length === 0) {
                var salt;
                var hashedPwd;

                salt = encryption.generateSalt();
                hashedPwd = encryption.generateHashedPassword(salt, 'Ivaylo');
                User.create({ username: 'ivaylo.kenov', salt: salt, hashPass: hashedPwd, roles: ['admin'] });
                salt = encryption.generateSalt();
                hashedPwd = encryption.generateHashedPassword(salt, 'Nikolay');
                User.create({ username: 'Nikolay.IT', salt: salt, hashPass: hashedPwd, roles: ['standard'] });
                salt = encryption.generateSalt();
                hashedPwd = encryption.generateHashedPassword(salt, 'Doncho');
                User.create({ username: 'Doncho', salt: salt, hashPass: hashedPwd });
                console.log('Users added to database...');
            }
        });
    }
}


