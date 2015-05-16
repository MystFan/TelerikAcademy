/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 4: Write an expression that checks for given integer if its third digit (right-to-left) is 7.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 4: Write an expression that checks for given integer if its third digit (right-to-left) is 7.');
console.log('---------------------------------------------------------------------------');


var numbers = [5, 701, 1732, 9703, 877, 777877, 9999799];

for (var i = 0; i < numbers.length; i++) {
    jsConsole.writeLine('Number: ' + numbers[i]);
    console.log('Number: ' + numbers[i]);

    var digit = numbers[i] % 100;
    digit = numbers[i] - digit;
    digit = digit % 1000;
    digit = digit / 100;

    if (digit === 7) {
        jsConsole.writeLine('Third digit: ' + digit + ' --> ' + true);
        console.log('Third digit: ' + digit + ' --> ' + true);
    }
    else {
        jsConsole.writeLine('Third digit: ' + digit + ' --> ' + false);
        console.log('Third digit: ' + digit + ' --> ' + false);
    }
}
