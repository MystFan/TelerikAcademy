/// <reference path="js-console.js"/>

//Problem 2: Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 2: Write a function that removes all elements with a given value.Attach it to the array type.Read about prototype and how to attach methods.')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 2: Write a function that removes all elements with a given value.Attach it to the array type.Read about prototype and how to attach methods.')
console.log('----------------------------------------------------------');

var arrayElements = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

Array.prototype.remove = function (element) {
    var elements = [];

    for (var i = 0; i < this.length; i++) {
        if (this[i] !== element) {
            elements.push(this[i]);
        }
    }
    return elements;
}
Array.prototype.asString = function (str) {
    var result = '';
    for (var i = 0; i < this.length; i++) {

        if (typeof this[i] === 'string') {
            result += "'" + this[i] + "'";
        }
        else {
            result += this[i];
        }
        if (i !== this.length - 1) {
            result += str;
        }
    }
    return result;
}
jsConsole.writeLine(arrayElements.remove(1).asString(', '));
console.log(arrayElements.remove(1));