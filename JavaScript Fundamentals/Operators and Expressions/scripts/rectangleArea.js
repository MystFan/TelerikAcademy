/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 3: Write an expression that calculates rectangle’s area by given width and height.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 3: Write an expression that calculates rectangle’s area by given width and height.');
console.log('---------------------------------------------------------------------------');

var width = 3;
var height = 4;

if (width > 0 && height > 0) {
    var area = width * height;
    jsConsole.writeLine('width: ' + width + ',  height: ' + height);
    jsConsole.writeLine('- Rectangle area: ' + area + ' cm.');
    console.log('width: ' + width + ',  height: ' + height);
    console.log('- Rectangle area: ' + area + ' cm.');
}

width = 2.5;
height = 3;

if (width > 0 && height > 0) {
    var area = width * height;
    jsConsole.writeLine('width: ' + width + ',  height: ' + height);
    jsConsole.writeLine('- Rectangle area: ' + area + ' cm.');
    console.log('width: ' + width + ',  height: ' + height);
    console.log('- Rectangle area: ' + area + ' cm.');
}

width = 5;
height = 5;

if (width > 0 && height > 0) {
    var area = width * height;
    jsConsole.writeLine('width: ' + width + ',  height: ' + height);
    jsConsole.writeLine('- Rectangle area: ' + area + ' cm.');
    console.log('width: ' + width + ',  height: ' + height);
    console.log('- Rectangle area: ' + area + ' cm.');
}