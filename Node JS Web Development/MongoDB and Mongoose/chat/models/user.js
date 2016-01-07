var mongoose = require('mongoose');
var userSchema = new mongoose.Schema({
	username: {type: String, require: true},
	password: {type: String, require: true}
});

userSchema.statics.uniqueUsername = function (username, callback) {
	this.find()
		.where('username').equals(username)
		.exec(function (err, users) {
			if (err) throw err;
			if (users.length !== 0){
				throw {
					message: 'Username already exists'
				};
			}
            
			callback();
		});
};

mongoose.model('User', userSchema);