/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 9: Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).');
jsConsole.writeLine('- Look problem9.png');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 9: Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).');
console.log('- Look problem9.png');
console.log('---------------------------------------------------------------------------');

var points = [
    {
        x: 1,
        y: 2
    },
    {
        x: 2.5,
        y: 2
    },
    {
        x: 0,
        y: 1
    },
    {
        x: 2.5,
        y: 1
    },
    {
        x: 2,
        y: 0
    },
    {
        x: 4,
        y: 0
    },
    {
        x: 2.5,
        y: 1.5
    },
    {
        x: 2,
        y: 1.5
    },
    {
        x: 1,
        y: 2.5
    },
    {
        x: -100,
        y: -100
    }
];

var circleRadius = 3;
var rectangleWidth = 6;
var rectangleHeight = 2;


for (var i = 0; i < points.length; i++) {
    var x = points[i].x;
    var y = points[i].y;

    jsConsole.writeLine('point(' + x + ', ' + y + ')');
    console.log('point(' + x + ', ' + y + ')');

    var inCircle = (circleRadius * circleRadius) >= ((x - 1) * (x - 1)) + ((y - 1) * (y - 1));

    if (inCircle) {
        if (((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1))) {
            jsConsole.writeLine('No');
            console.log('No');
        }
        else {
            jsConsole.writeLine('Yes');
            console.log('Yes');
        }
    }
    else {
        jsConsole.writeLine('No');
        console.log('No');
    }
}
