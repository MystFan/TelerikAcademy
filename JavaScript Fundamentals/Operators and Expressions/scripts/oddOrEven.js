/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 1: Write an expression that checks if given integer is odd or even.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 1: Write an expression that checks if given integer is odd or even.');
console.log('---------------------------------------------------------------------------');

var variables = [3, 2, -2, -1, 0];
for (var i = 0; i < variables.length; i++) {
    var variable = variables[i];
    if (variable % 2 !== 0) {
        jsConsole.writeLine(variable + ' is odd');
        console.log(variable + ' is odd');
    }
    if (variable % 2 === 0) {
        jsConsole.writeLine(variable + ' is even');
        console.log(variable + ' is even');
    }
}

