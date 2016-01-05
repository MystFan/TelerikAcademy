var http = require('http');
var url = require('url');
var querystring = require('querystring');
var fs = require('fs');
var path = require('path');
var Busboy = require('busboy');
var Handlebars = require('handlebars');
var uuid = require('node-uuid');
var db = require('./server/data/data')();

http.createServer(function (req, res) {
    var contentType = 'text/html';
    var filePath = '.' + req.url;
    var data = {};
    var parsedUrl = url.parse(req.url, true);
    var query = querystring.parse(parsedUrl.query);

    if (filePath == './') {
        filePath = './server/index.html';
    }

    if (req.url === '/files') {
        db.allFiles(function (err, content) {
            data = JSON.parse(content);
            filePath === './server/all-files.html';
        });

        filePath = './server/all-files.html';
    }

    if (req.url == '/upload') {
        if (req.method == 'POST') {
            var busboy = new Busboy({ headers: req.headers });
            var guid = uuid.v1();
            var dir = __dirname + '/files/' + guid;
            var fileToSave = {};
            fileToSave.guid = guid;
            fs.mkdir(dir);

            busboy.on('file', function (fieldname, file, filename, encoding, mimetype) {
                var saveTo = path.join(dir + '/' + filename);
                var writeStream = fs.createWriteStream(saveTo);
                fileToSave.name = filename;

                file.on('data', function (data) {
                    writeStream.write(data);
                });

                file.on('end', function () {
                    db.saveFile(fileToSave);
                    writeStream.end();
                });
            });

            busboy.on('finish', function () {
                res.writeHead(301, { Location: '/' });
                res.end();
            });

            req.pipe(busboy);
        }

        filePath = './server/upload.html';
    }

    if (parsedUrl.pathname === '/download') {
        var file = db.getFile(parsedUrl.query.id);
        filePath = path.join(file.url);
        var stat = fs.statSync(filePath);

        contentType = 'application/octet-stream';
        res.writeHead(200, {
            'Content-Type': contentType,
            'Content-Length': stat.size,
            'Content-Disposition': 'attachment; filename="' + file.name + '"'
        });

        var readStream = fs.createReadStream(filePath);
        readStream.pipe(res);
        return;
    }

    var fileExtenssion = path.extname(filePath);

    switch (fileExtenssion) {
        case '.js':
            contentType = 'text/javascript';
            break;
        case '.css':
            contentType = 'text/css';
            break;
    }


    fs.exists(filePath, function (exists) {
        if (exists) {
            fs.readFile(filePath, function (error, content) {
                if (error) {
                    res.writeHead(500);
                    res.end();
                }
                else {
                    res.writeHead(200, { 'Content-Type': contentType });
                    var template = Handlebars.compile(content.toString());
                    var html = template(data);
                    res.end(html, 'utf-8');
                }
            });
        }
        else {
            res.writeHead(404);
            res.end();
        }
    });

}).listen(1234);

console.log('Server is running on port ' + 1234)