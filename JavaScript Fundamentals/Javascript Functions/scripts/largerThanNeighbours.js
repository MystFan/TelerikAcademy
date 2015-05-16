jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 6: Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 6: Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).');
console.log('----------------------------------------------------------');

function largerThanNeighbours(array, index) {
    var numbers = array;
    var position = index;
    var isLarger = false;
    for (var i = 0; i < numbers.length; i++) {
        if (i > 0 && i < (numbers.length - 1)) {
            if (i == position) {
                if (numbers[i] > numbers[i + 1] && numbers[i] > numbers[i - 1]) {
                    isLarger = true;
                    break;
                }
            }
        }
        if ((i == 0) && (i == position)) {
            if (numbers[i] > numbers[i + 1]) {
                isLarger = true;
                break;
            }
        }
        if ((i == numbers.length - 1) && (i == position)) {
            if (numbers[i] > numbers[i - 1]) {
                isLarger = true;
                break;
            }
        }
    }
    return isLarger;
}

var numbers = [1, 3, 5, 7, 9, 2, 4, 6, 8];
jsConsole.writeLine('[1, 3, 5, 7, 9, 2, 4, 6, 8]');
console.log('[1, 3, 5, 7, 9, 2, 4, 6, 8]');

var index = 4;
if (largerThanNeighbours(numbers, index)) {
    jsConsole.writeLine('Number at position ' + index + ' is bigger than its two neighbours');
    console.log('Number at position ' + index + ' is bigger than its two neighbours');
}
else {
    jsConsole.writeLine('Number at position ' + index + ' is not bigger than its two neighbours');
    console.log('Number at position ' + index + ' is not bigger than its two neighbours');
}
