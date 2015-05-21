/// <reference path="js-console.js"/>

print('Problem 3: Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).');

var text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
var subString = 'in';

function substringCount(originalText, searchValue) {
    var index = -1;
    var counter = 0;
    while (true) {
        index = originalText.toLowerCase().indexOf(searchValue.toLowerCase(), index + 1)
        if (index == -1) {
            break;
        }
        counter++;
    }
    return counter;
}
jsConsole.writeLine('Text: ' + text);
console.log('Text: ' + text);
jsConsole.writeLine('Substring "' + subString + '" is contains ' + substringCount(text, subString) + ' times.');
console.log('Substring "' + subString + '" is contains ' + substringCount(text, subString) + ' times.');