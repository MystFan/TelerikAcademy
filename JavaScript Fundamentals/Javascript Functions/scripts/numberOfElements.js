jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 4: Write a function to count the number of div elements on the web page.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 4: Write a function to count the number of div elements on the web page.');
console.log('----------------------------------------------------------');


function getElementsCount(elementName) {
    var elementCount = document.body.getElementsByTagName(elementName).length;
    return elementCount;
}

jsConsole.writeLine(getElementsCount('div') + " divs");
console.log(getElementsCount('div') + " divs");