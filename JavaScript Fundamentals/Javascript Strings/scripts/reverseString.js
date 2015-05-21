/// <reference path="js-console.js"/>

print('Problem 1: Write a JavaScript function that reverses a string and returns it.');

var sample = 'sample';

function reverseString(value) {
    var charArray = value.split('');
    var reversedString = charArray.reverse().join('');
    return reversedString
}

jsConsole.writeLine(sample + ' --> ' + reverseString(sample));
console.log(sample + ' --> ' + reverseString(sample));