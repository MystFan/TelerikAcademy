
jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 5: Write a function that counts how many times given number appears in given array.Write a test function to check if the function is working correctly.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 5: Write a function that counts how many times given number appears in given array.Write a test function to check if the function is working correctly.');
console.log('----------------------------------------------------------');

var numbers = [1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 9];
var number = 8;


function countNumberAppears(array, num) {
    var count = 0;
    for (var i = 0; i < array.length; i++) {
        if (array[i] === num) {
            count++
        }
    }
    return count;
}
function testCountNumberAppears(func) {
    var numbersTestArray = [9, 7, 5, 4, 3, -2, -2, -2, -2, 5, 6, 7];
    jsConsole.writeLine('[9, 7, 5, 4, 3, -2, -2, -2, -2, 5, 6, 7]');
    console.log('[9, 7, 5, 4, 3, -2, -2, -2, -2, 5, 6, 7]');
    var testNumber1 = -2;
    var appearNumber1 = 4;
    var testNumber2 = 3;
    var appearNumber2 = 2;

    jsConsole.writeLine('Test 1: Number ' + testNumber1 + ' is contains ' + appearNumber1 + ' times in array.');
    console.log('Test 1: Number ' + testNumber1 + ' is contains ' + appearNumber1 + ' times in array.');
    if (func(numbersTestArray, testNumber1) === appearNumber1) {
        jsConsole.writeLine("Corect");
        console.log("Corect");
    }
    else{
        jsConsole.writeLine("Incorect");
        console.log("Incorect");
    }

    jsConsole.writeLine('Test 2: Number ' + testNumber2 + ' is contains ' + appearNumber2 + ' times in array.');
    console.log('Test 2: Number ' + testNumber2 + ' is contains ' + appearNumber2 + ' times in array.');
    if (func(numbersTestArray, appearNumber2) === testNumber2) {
        jsConsole.writeLine("Corect");
        console.log("Corect");
    }
    else {
        jsConsole.writeLine("Incorect");
        console.log("Incorect");
    }
}
jsConsole.writeLine('[1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 9]');
console.log('[1, 2, 3, 4, 4, 4, 5, 6, 7, 8, 8, 8, 9]');

jsConsole.writeLine('Number ' + number + ' is contains ' + countNumberAppears(numbers, number) + ' times in array.');
console.log('Number ' + number + ' is contains ' + countNumberAppears(numbers, number) + ' times in array.');

jsConsole.writeLine('Tests');
console.log('Tests');
testCountNumberAppears(countNumberAppears);