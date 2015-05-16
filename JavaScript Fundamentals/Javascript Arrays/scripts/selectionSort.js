jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 5: Sorting an array means to arrange its elements in increasing order.Write a script to sort an array.Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 5: Sorting an array means to arrange its elements in increasing order.Write a script to sort an array.Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.')
console.log('--------------------------------------------------------------------');

console.log('Before: [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10]');
jsConsole.writeLine('Before: [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10]');

var numbers = [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10];
var currentSmallestNumber;
var smallestNumber = numbers[0];
var position;
var index = 0;

for (var j = 0; j < numbers.length; j++) {
    for (var i = index; i < numbers.length; i++) {

        currentSmallestNumber = numbers[i];

        if (smallestNumber >= currentSmallestNumber) {
            smallestNumber = currentSmallestNumber;
            position = i;
        }
    }
    if (position != j) {
        numbers[position] = numbers[j];
        numbers[j] = smallestNumber;
    }
    index++;
    smallestNumber = numbers[index];
}

console.log('After: ' + numbers.join(', '));
jsConsole.writeLine('After: ' + numbers.join(", "));