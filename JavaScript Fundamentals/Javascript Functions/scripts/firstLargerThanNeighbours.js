jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 7: Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.Use the function from the previous exercise.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 7: Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.Use the function from the previous exercise.');
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

function firstLargerThanNeighbours(arrayOfNumbers) {
    var index = -1;
    for (var i = 0; i < arrayOfNumbers.length; i++) {
        if (largerThanNeighbours(arrayOfNumbers, i)) {
            index = i;
            break;
        }
    }
    return index;
}
var numbers = [1, 3, 5, 7, 9, 2, 4, 6, 8];
jsConsole.writeLine('[1, 3, 5, 7, 9, 2, 4, 6, 8]');
console.log('[1, 3, 5, 7, 9, 2, 4, 6, 8]');

if(firstLargerThanNeighbours(numbers) >= 0){
    jsConsole.writeLine('First element in array that is larger than its neighbours at index --> ' + firstLargerThanNeighbours(numbers));
    console.log('First element in array that is larger than its neighbours at index --> ' + firstLargerThanNeighbours(numbers));
}
else {
    jsConsole.writeLine('No such element.')
    console.log('No such element.');
}


