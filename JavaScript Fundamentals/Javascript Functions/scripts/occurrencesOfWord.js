jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 3: Write a function that finds all the occurrences of word in a text.The search can be case sensitive or case insensitive.Use function overloading.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 3: Write a function that finds all the occurrences of word in a text.The search can be case sensitive or case insensitive.Use function overloading.');
console.log('----------------------------------------------------------');



function getWordCount(str, string, isCaseSensitive) {

    function getWordCountCaseInsensitive(string) {
        var count = 0;
        var lowerCase = string.toLowerCase();
        var match = "";
        var position = 0;
        //for (var i = 0; i < string.length; i++) {
        //    if (string[i] == string[i].toUpperCase()) {
        //        lowerCase = lowerCase + string[i].toLowerCase();
        //    }
        //    else {
        //        lowerCase = lowerCase + string[i];
        //    }
        //}
        for (var ch = 0; ch < str.length - string.length + 1; ch++) {

            position = ch;
            for (var i = 0; i < string.length; i++) {
                if (str[position] == str[position].toUpperCase()) {
                    match = match + str[position].toLowerCase();
                    position++;
                }
                else {
                    match = match + str[position];
                    position++;
                }
            }
            if (match == lowerCase) {
                count++;
            }
            match = "";
        }
        return count;
    }
    function getWordCountCaseSensitive(string) {
        var count = 0;
        var match = "";
        var position = 0;
        for (var ch = 0; ch < str.length - string.length + 1; ch++) {
            position = ch;
            for (var i = 0; i < string.length; i++) {

                match = match + str[position];
                position++;
            }
            if (match == string) {
                count++;
            }
            match = "";
        }
        return count;
    }

    switch (arguments.length) {
        case 2:
            return getWordCountCaseInsensitive(string);
        case 3:
            return isCaseSensitive ? getWordCountCaseSensitive(string) : getWordCountCaseInsensitive(string);
    }
}

var text = "My name is Doncho Minkov and I am 23 years-old Name";
var word = "name";
jsConsole.writeLine('Text: ' + text);
jsConsole.writeLine('Word: ' + word);
console.log('Text: ' + text);
console.log('Word: ' + word);
jsConsole.writeLine("Default Case Insensitive => " + getWordCount(text, word));
console.log("Default Case Insensitive => " + getWordCount(text, word));
jsConsole.writeLine("Case Insensitive => " + getWordCount(text, word, false));
console.log("Case Insensitive => " + getWordCount(text, word, false));
jsConsole.writeLine("Case Sensitive => " + getWordCount(text, word, true));
console.log("Case Sensitive => " + getWordCount(text, word, true));