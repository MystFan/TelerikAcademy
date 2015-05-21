//Problem 11. String format

//Write a function that formats a string using placeholders.
//The function should work with up to 30 placeholders and all types.

print('Problem 11: Write a function that formats a string using placeholders.The function should work with up to 30 placeholders and all types.');

function stringFormat(line) {
    var words = [];
    var placeHolders = [];
    var placeHoldersText = arguments[0];
    for (var i = 1; i < arguments.length; i++) {
        words.push(arguments[i]);
    }
    var j = 0;
    var index = -1;
    while (words[j] !== undefined) {
        while (true) {
            index = placeHoldersText.indexOf("{" + j + "}", index + 1);
            if (index == -1) {
                break;
            }
            placeHoldersText = placeHoldersText.replace("{" + j + "}", words[j]);
        }
        placeHoldersText = placeHoldersText.replace("{" + j + "}", words[j]);
        j++;
    }

    return placeHoldersText;
};
jsConsole.writeLine(stringFormat("Zoro {1} {2} {0} ", "pesho", "gosho", "kosho"));
console.log(stringFormat("Zoro {1} {2} {0} ", "pesho", "gosho", "kosho"));

var strHello = stringFormat('Hello {0}!', 'Peter');
//strHello = 'Hello Peter!';
jsConsole.writeLine(strHello);
console.log(strHello);

var format = '{0}, {1}, {0} text {2}';
var strNames = stringFormat(format, 1, 'Pesho', 'Gosho');
jsConsole.writeLine(strNames);
console.log(strNames);
//strNames = '1, Pesho, 1 text Gosho'