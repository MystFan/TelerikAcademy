//Problem 7. Parse URL

//Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Return the elements in a JSON object.

print('Problem 7: Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.Return the elements in a JSON object.')

var telerikUrl = 'http://telerikacademy.com/Courses/Courses/Details/239';
var test1 = "http://www.devbg.org/forum/index.php";
var test2 = "http://p2pbg.com/index.php?page=torrents&active=1&category=1;7;11;14;15;16;17;18;24;35;51&order=data&by=DESC&pages=2";

function parse(text) {
    var i, j, k, protocolStr, serverStr, resourceStr, www, position, index, json;

    protocolStr = ''
    for (i = 0; i < text.length; i++) {
        if (text[i] == ':') {
            break;
        }
        protocolStr = protocolStr + text[i];
    }

    serverStr = '';
    www = "://";
    position = 0;
    index = text.indexOf(www, 0);

    for (j = index + 3; j < text.length; j++) {
        if (text[j] == '/') {
            position = j;
            break;
        }
        serverStr = serverStr + text[j];
    }

    resourceStr = '';
    for (k = position; k < text.length; k++) {
        resourceStr = resourceStr + text[k];
    }

    json = {
        protocol: protocolStr,
        server: serverStr,
        resource: resourceStr
    };
    return json;
}

jsConsole.writeLine(JSON.stringify(parse(telerikUrl)));
jsConsole.writeLine(JSON.stringify(parse(test1)));
jsConsole.writeLine(JSON.stringify(parse(test2)));
console.log(JSON.stringify(parse(telerikUrl)));
console.log(JSON.stringify(parse(test1)));
console.log(JSON.stringify(parse(test2)));