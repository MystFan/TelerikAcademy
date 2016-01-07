var fs = require('fs'),
    FILES_DIR = __dirname + '/../../files';

module.exports = {
    createDir: function(path, dirName){
        fs.mkdirSync(FILES_DIR + path + dirName);
    }
}