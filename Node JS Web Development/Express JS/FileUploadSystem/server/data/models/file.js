var mongoose = require('mongoose');
var File;

module.exports = {
    init: function () {
        var fileSchema = new mongoose.Schema({
            url: {type: String, required: true, unique: true},
            uploadDate: {type: Date, default: new Date()},
            filename: String,
            isPrivate: Boolean,
            uploader: {type: String, required: true}
        });

        File = mongoose.model('File', fileSchema);
    }
}