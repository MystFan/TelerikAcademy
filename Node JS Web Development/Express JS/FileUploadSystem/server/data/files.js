var File = require('mongoose').model('File');

module.exports = {
    create: function (file, callback) {
        File.create(file, callback);
    },
    publicFiles: function (callback) {
        File.find({ isPrivate: false }).exec(function (err, files) {
            if (err) {
                console.log(err);
            }

            callback(files);
        })
    },
    getUserFiles: function(userId, callback){
        File.find({uploader: userId}).exec(function(err, files){
            if(err){
                console.log(err);
            }
            
            callback(files);
        })
    },
    getFileById: function (fileId, callback) {
        File.findOne({_id: fileId}).exec(function(err, file){
            if(err){
                console.log(err);
            }
            
            callback(file);
        })
    }
}