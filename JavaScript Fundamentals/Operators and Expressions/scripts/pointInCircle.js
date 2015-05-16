/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 6: Write an expression that checks if given point (x,  y) is within a circle K(O, 5).');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 6: Write an expression that checks if given point (x,  y) is within a circle K(O, 5).');
console.log('---------------------------------------------------------------------------');

var points = [
    {
        x: 0,
        y: 1
    },
    {
        x: -2,
        y: 0
    },
    {
        x: -1,
        y: 2
    },
    {
        x: 1.5,
        y: -1
    },
    {
        x: -1.5,
        y: -1.5
    },
    {
        x: 100,
        y: -30
    },
    {
        x: 0,
        y: 0
    },
    {
        x: 0.2,
        y: -0.8
    },
    {
        x: 0.9,
        y: -1.93
    },
    {
        x: 1,
        y: 1.655
    }
];

var circleRadius = 5;
jsConsole.writeLine('circle radius: ' + circleRadius);
console.log('circle radius: ' + circleRadius);

for (var i = 0; i < points.length; i++) {
    var x = points[i].x;
    var y = points[i].y;

    jsConsole.writeLine('point(' + x + ', ' + y + ')');
    console.log('point(', x + ', ' + y + ')');

    var inCircle = (circleRadius * circleRadius) >= (x * x) + (y * y);

    if (inCircle) {
        jsConsole.writeLine('The point is in the circle');
        console.log('The point is in the circle');
    }
    else {
        jsConsole.writeLine('The point is outside the circle');
        console.log('The point is outside the circle');
    }
}
