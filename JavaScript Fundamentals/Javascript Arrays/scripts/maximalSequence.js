jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 3: Write a script that finds the maximal sequence of equal elements in an array.')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 3: Write a script that finds the maximal sequence of equal elements in an array.')
console.log('--------------------------------------------------------------------');

jsConsole.writeLine('Example: [2, 1, 1, 2, 3, 3, 2, 2, 2, 1]');
console.log('Example: [2, 1, 1, 2, 3, 3, 2, 2, 2, 1]');

var numbers = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];
var currentCounter = 1;
var number = numbers[0];
var currentNumber = 0;
var maxSequence = 1;

for (var i = 0; i < numbers.length - 1; i++) {
    if (numbers[i] === numbers[i + 1]) {
        currentNumber = numbers[i];
        currentCounter++;
    }
    if (numbers[i] !== numbers[i + 1]) {
        currentCounter = 1;
    }
    if (maxSequence < currentCounter) {
        maxSequence = currentCounter;
        number = currentNumber;
    }
}

for (var i = 0; i < maxSequence; i++) {
    jsConsole.write(number + ' ');
    console.log(number + ' ');
}
jsConsole.writeLine();