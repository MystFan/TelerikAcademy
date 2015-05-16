jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 6: Write a script that finds the most frequent number in an array. ')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 6: Write a script that finds the most frequent number in an array. ')
console.log('--------------------------------------------------------------------');

jsConsole.writeLine('Example: [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]');
console.log('Example: [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]');

var numbers = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];
var mostFrequent = 1;
var currentFrequent = 1;
var number;
var currentNumber;

for (var i = 0; i < numbers.length; i++) {
    for (var j = i + 1; j < numbers.length; j++) {
        if (numbers[i] === numbers[j]) {
            currentFrequent++;
            currentNumber = numbers[i];
        }
    }
    if (mostFrequent <= currentFrequent) {
        mostFrequent = currentFrequent;
        number = currentNumber;
    }
    currentFrequent = 1;
}

jsConsole.writeLine(number + "(" + mostFrequent + " times" + ")");
console.log(number + "(" + mostFrequent + " times" + ")");