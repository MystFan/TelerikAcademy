jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 7: Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 7: Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.')
console.log('--------------------------------------------------------------------');

console.log('Before sort: [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10]');
jsConsole.writeLine('Before sort: [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10]');


var numbers = [9, 7, 77, 5, 5, 3, 2, 1, -4, 6, 8, 10];
function orderBy(a, b) {
    return (a == b) ? 0 : (a > b) ? 1 : -1
};
numbers.sort(orderBy);
jsConsole.writeLine('After sort: [' + numbers.join(", ") + ']');

var value = 9;
var left = 0;
var right = numbers.length - 1;

while (left <= right) {

    var middle = ((left + right) / 2);
    middle = parseInt(middle);
    if (numbers[middle] == value) {
        break;
    }
    else if (numbers[middle] > value) {
        right = middle - 1;
    }
    else {
        left = middle + 1;
    }
}

jsConsole.writeLine("Number " + value + " at index " + middle);
console.log("Number " + value + " at index " + middle);