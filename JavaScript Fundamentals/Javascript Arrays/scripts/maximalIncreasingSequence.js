jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 4: Write a script that finds the maximal increasing sequence in an array.')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 4: Write a script that finds the maximal increasing sequence in an array.')
console.log('--------------------------------------------------------------------');

jsConsole.writeLine('Example: [3, 2, 3, 4, 2, 2, 4]');
console.log('Example: [3, 2, 3, 4, 2, 2, 4]');

var numbers = [3, 2, 3, 4, 2, 2, 4];
var startNumber;
var currentStart;
var maxSequence = 1;
var counter = 1;

for (var i = 0; i < numbers.length; i++) {

    if (numbers[i + 1] > (numbers[i])) {
        counter++;
        if (counter <= 2) {
            currentStart = i;
        }
    }
    if (numbers[i + 1] < (numbers[i])) {
        counter = 1;
    }
    if (maxSequence < counter) {
        maxSequence = counter;
        startNumber = currentStart;
    }
}

for (var j = startNumber; j < maxSequence + startNumber; j++) {
    jsConsole.write(numbers[j] + ' ');
    console.log(numbers[j] + ' ')
}
jsConsole.writeLine();