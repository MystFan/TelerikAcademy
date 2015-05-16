jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 2: Write a script that compares two char arrays lexicographically (letter by letter).')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 2: Write a script that compares two char arrays lexicographically (letter by letter).')
console.log('--------------------------------------------------------------------');


var firstArray = ['g', 'o', 's', 'h', 'o'];
var secondArray = ['p', 'e', 's', 'h', 'O'];

var minLength = firstArray.length;
if (minLength > secondArray.length) {
    minLength = secondArray.length;
}

for (var i = 0; i < minLength; i++) {
    if (firstArray[i] < secondArray[i]) {
        jsConsole.writeLine(firstArray.join(", "));
        console.log(firstArray.join(", "));
        break;
    }
    else if (firstArray[i] > secondArray[i]) {
        jsConsole.writeLine(secondArray.join(", "));
        console.log(secondArray.join(", "));
        break;
    }
    else {
        jsConsole.writeLine(firstArray.join(", "));
        console.log(firstArray.join(", "));
        jsConsole.writeLine(secondArray.join(", "));
        console.log(secondArray.join(", "));
        break;
    }
}