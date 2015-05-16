
function run() {
    var taskName;
    taskName = document.getElementById('task-menager').value;
    if (taskName === 'Problem 1: Numbers') {
        // TASK 1 CODE
        printText('Write a script that prints all the numbers from 1 to N', 1);
        var label = document.getElementById('message');
        label.innerHTML = 'Enter value for N and click the button';
        var button = document.getElementById('btn-run');
        button.innerHTML = 'print numbers';
        button.onclick = function printNumbersToN() {
            var n = document.getElementById('tb-number').value - 0;
            var i;
            if (isNaN(n)) {
                jsConsole.writeLine('Invalid input number');
                console.log('Invalid input number');
                return;
            }

            var numbers = '';
            for (i = 1; i <= n; i++) {
                if (i == n) {
                    numbers += i;
                }
                else {
                    numbers += i + ", ";
                }
            }
            jsConsole.writeLine(numbers);
            console.log(numbers);
        }
    }
    else if (taskName === 'Problem 2: Numbers not divisible') {
        // TASK 2 CODE
        printText('Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.', 2);
        var label = document.getElementById('message');
        label.innerHTML = 'Enter value for N and click the button';
        var button = document.getElementById('btn-run');
        button.innerHTML = 'print numbers';
        button.onclick = function printDivisibleNumbersToN() {
            var n = document.getElementById('tb-number').value - 0;
            var i, notDivisibleNumbers;

            if (isNaN(n)) {
                jsConsole.writeLine('Invalid input number');
                console.log('Invalid input number');
                return;
            }

            notDivisibleNumbers = [];
            for (i = 1; i <= n; i++) {
                if (!((i % 3 === 0) && (i % 7 === 0))) {
                    notDivisibleNumbers.push(i);
                }
            }
            jsConsole.writeLine(notDivisibleNumbers.join(', '));
            console.log(notDivisibleNumbers.join(', '));
        }
    }
    else if (taskName === 'Problem 3: Min/Max of sequence') {
        // TASK 3 CODE
        printText('Write a script that finds the max and min number from a sequence of numbers', 3);
        var label = document.getElementById('message');
        label.innerHTML = 'Enter numbers separated from white space and click the button';
        var button = document.getElementById('btn-run');
        button.innerHTML = 'Find';
        button.onclick = function findMaxAndMin() {
            var numbersInput = document.getElementById('tb-number').value;
            var splitInput = numbersInput.split(' ');
            var numbers = [];
            for (var i = 0; i < splitInput.length; i++) {
                if (splitInput[i] !== '') {
                    var number = parseInt(splitInput[i]);
                    if (!isNaN(number)) {
                        numbers.push(number);
                    }
                }
            }

            var max, min;
            if (numbers.length === 0) {
                max = 0;
                min = 0;
            }
            else {
                max = numbers[0];
                min = numbers[0];
            }

            for (var i = 0; i < numbers.length; i++) {
                if (max < numbers[i]) {
                    max = numbers[i];
                }
            }

            for (var i = 0; i < numbers.length; i++) {
                if (min > numbers[i]) {
                    min = numbers[i];
                }
            }

            jsConsole.writeLine('max --> ' + max);
            jsConsole.writeLine('min --> ' + min);
            console.log('max --> ' + max);
            console.log('min --> ' + min);
        }
    }
    else if (taskName === 'Problem 4: Lexicographically smallest') {
        // TASK 4 CODE
        printText('Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects', 4);
        var label = document.getElementById('message');
        label.innerHTML = 'Click to find lexicographically smallest and largest property';
        var button = document.getElementById('btn-run');
        button.innerHTML = 'Find';
        button.onclick = function sortObjectProperties() {
            var documentProperties, windowProperties, navigatorProperties
            documentProperties = [];
            for (var prop in document) {
                documentProperties.push(prop);
            }
            documentProperties.sort(function (a, b) { return a.localeCompare(b); });

            windowProperties = [];
            for (var prop in window) {
                windowProperties.push(prop);
            }
            windowProperties.sort(function (a, b) { return a.localeCompare(b); });

            navigatorProperties = [];
            for (var prop in navigator) {
                navigatorProperties.push(prop);
            }
            navigatorProperties.sort(function (a, b) { return a.localeCompare(b); });

            jsConsole.writeLine('document lexicographically smallest property --> ' + documentProperties[0]);
            jsConsole.writeLine('document lexicographically largest property --> ' + documentProperties[documentProperties.length - 1]);
            jsConsole.writeLine('window lexicographically smallest property --> ' + windowProperties[0]);
            jsConsole.writeLine('window lexicographically largest property --> ' + windowProperties[windowProperties.length - 1]);
            jsConsole.writeLine('navigator lexicographically smallest property --> ' + navigatorProperties[0]);
            jsConsole.writeLine('navigator lexicographically largest property --> ' + navigatorProperties[navigatorProperties.length - 1]);
            console.log('document lexicographically smallest property --> ' + documentProperties[0]);
            console.log('document lexicographically largest property --> ' + documentProperties[documentProperties.length - 1]);
            console.log('window lexicographically smallest property --> ' + windowProperties[0]);
            console.log('window lexicographically largest property --> ' + windowProperties[windowProperties.length - 1]);
            console.log('navigator lexicographically smallest property --> ' + navigatorProperties[0]);
            console.log('navigator lexicographically largest property --> ' + navigatorProperties[navigatorProperties.length - 1]);
        }
    }
    function printText(text, task) {
        jsConsole.writeLine('-------------------------------------------------------------------------------');
        jsConsole.writeLine('Problem '+ task +': ' + text);
        jsConsole.writeLine('-------------------------------------------------------------------------------');
        console.log('-------------------------------------------------------------------------------');
        console.log('Problem ' + task + ': ' + text);
        console.log('-------------------------------------------------------------------------------');
    }
}
run();
