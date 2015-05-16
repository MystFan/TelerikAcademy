/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 5: Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.The bits are counted from right to left, starting from bit #0.The result of the expression should be either 1 or 0.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 5: Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.The bits are counted from right to left, starting from bit #0.The result of the expression should be either 1 or 0.');
console.log('---------------------------------------------------------------------------');

var numbers = [5, 8, 0, 15, 5343, 62241];
for (var i = 0; i < numbers.length; i++) {
    var bitPosition = 3;
    var mask = 1 << bitPosition;

    console.log('Number ' + numbers[i] + '  binary --> ' + numbers[i].toString(2));
    jsConsole.writeLine('Number ' + numbers[i] + '  binary --> ' + numbers[i].toString(2));

    var bit = (mask & numbers[i]) >> bitPosition;
    jsConsole.writeLine('Third bit is ' + bit);
    console.log('Third bit is ' + bit);
}
