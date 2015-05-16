
/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine("Problem 8: Write an expression that calculates trapezoid's area by given sides a and b and height h.");
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log("Problem 8: Write an expression that calculates trapezoid's area by given sides a and b and height h.");
console.log('---------------------------------------------------------------------------');

var trapezoids = [
    {
        a: 5,
        b: 7,
        h:12
    },
    {
        a: 2,
        b: 1,
        h: 33
    },
    {
        a: 8.5,
        b: 4.3,
        h: 2.7
    },
    {
        a: 100,
        b: 200,
        h: 300
    },
    {
        a: 0.222,
        b: 0.333,
        h: 0.555
    }
];

for (var i = 0; i < trapezoids.length; i++) {
    var base_a = trapezoids[i].a;
    var base_b = trapezoids[i].b;
    var height = trapezoids[i].h;
    var area = ((base_a + base_b) / 2) * height;

    if (base_a > 0 && base_b > 0 && height > 0) {
        jsConsole.writeLine('base a = ' + base_a + ' cm.');
        jsConsole.writeLine('base b = ' + base_b + ' cm.');
        jsConsole.writeLine('height = ' + height + ' cm.');
        jsConsole.writeLine('Area = ' + '((a + b) / 2) * h = ' + area + ' cm.');
        console.log('base a = ' + base_a + ' cm.');
        console.log('base b = ' + base_b + ' cm.');
        console.log('height = ' + height + ' cm.');
        console.log('Area = ' + '((a + b) / 2) * h = ' + area + ' cm.');
    }
    else {
        jsConsole.writeLine('Shape is not trapezoid');
        console.log('Shape is not trapezoid');
    }
}
