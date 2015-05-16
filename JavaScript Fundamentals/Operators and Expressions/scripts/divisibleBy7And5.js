/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 2: Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 2: Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.');
console.log('---------------------------------------------------------------------------');


var numbers = [3, 0, 5, 7, 35, 140];
for (var i = 0; i < numbers.length; i++) {
    var booleanVariable = (numbers[i] % 5 == 0) && (numbers[i] % 7 == 0);

    if (booleanVariable) {
        jsConsole.writeLine('Number ' + numbers[i] + ' can be divided');
        jsConsole.writeLine(booleanVariable);
        console.log('Number ' + numbers[i] + ' can be divided');
        console.log(booleanVariable);
    }
    else {
        jsConsole.writeLine("Number " + numbers[i] + " can't be divided")
        jsConsole.writeLine(booleanVariable);
        console.log("Number " + numbers[i] + " can't be divided");
        console.log(booleanVariable);
    }
    booleanVariable = false;
}


