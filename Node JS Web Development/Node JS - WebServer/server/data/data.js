var fs = require('fs'),
    DB_PATH = './server/data/db.json',
    db = { files: [] };

module.exports = function () {

    fs.readFile(DB_PATH, 'utf-8', function (err, content) {
        if (err) {
            console.log(err);
        }

        if (content.length) {
            db = JSON.parse(content);
        }
        else {
            fs.writeFile(DB_PATH, '{ "files": []}', function (err) {
                if (err) {
                    console.log(err);
                }
            });
        }
    });

    return {
        allFiles: function (callback) {
            fs.readFile(DB_PATH, 'utf-8', callback);
        },
        getFile: function (guid) {
            var index;
            for (var i = 0; i < db.files.length; i++) {
                if(db.files[i].guid === guid){
                    index = i;
                    break;
                }  
            }

            return db.files[index];
        },
        saveFile: function (file) {
            file.id = db.files.length + 1;
            file.url = 'files/' + file.guid + '/' + file.name;
            db.files.push(file);
            var dbString = JSON.stringify(db);
            fs.writeFile(DB_PATH, dbString, function (err) {
                if (err) {
                    console.log(err);
                }
            });
        }
    }
}