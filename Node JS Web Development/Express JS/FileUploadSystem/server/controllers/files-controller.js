var CONTROLLER_NAME = 'files',
    busboy = require('connect-busboy'),
    fs = require('fs')
files = require('../data/files'),
FILES_DIR = __dirname + '/../../files',
path = require('path');


module.exports = {
    getUpload: function (req, res, next) {
        res.render(CONTROLLER_NAME + '/upload', { currentUser: req.user });
    },
    postUpload: function (req, res, next) {
        var fstream;
        req.pipe(req.busboy);
        var newFile = {};
        var hasPrivateField = false;

        req.busboy.on('file', function (fieldname, file, filename) {
            var fileDir = FILES_DIR + '/' + req.user.username + '/' + filename;
            newFile['url'] = fileDir;
            newFile['filename'] = filename;
            fstream = fs.createWriteStream(fileDir);
            file.pipe(fstream);
        });

        req.busboy.on('field', function (fieldname, val) {
            hasPrivateField = true;
            newFile['isPrivate'] = val;
        });

        req.busboy.on('finish', function () {
            if (!hasPrivateField) {
                newFile['isPrivate'] = false;
            }
            
            newFile['uploader'] = req.user._id;
            files.create(newFile);
            res.redirect('/');
        });
    },
    download: function (req, res, next) {
        var fileId = req.query.fileId;
        files.getFileById(fileId, function (file) {
            var fileUrl = file.url;
            res.download(fileUrl);
        });
    },
    getFiles: function (req, res, next) {
        files.publicFiles(function (files) {
            res.render('files/all-files', { currentUser: req.user, files: files, prettyDate: prettyDate })
        });
    }
}

function prettyDate(dateString) {
    var date = new Date(dateString);
    var day = date.getDate();
    var monthNames = ["Jan", "Feb", "Mar", "Apr", "May", "Jun",
        "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
    var month = monthNames[date.getMonth()];
    var year = date.getFullYear();
    return day + ' ' + month + ' ' + year;
}