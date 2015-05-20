/// <reference path="js-console.js"/>

//Problem 1: Write functions for working with shapes in standard Planar coordinate system.
//    Points are represented by coordinates P(X, Y)
//    Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 1: Write functions for working with shapes in standard Planar coordinate system.Points are represented by coordinates P(X, Y).Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2)).Calculate the distance between two points.Check if three segment lines can form a triangle.')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 1: Write functions for working with shapes in standard Planar coordinate system.Points are represented by coordinates P(X, Y).Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2)).Calculate the distance between two points.Check if three segment lines can form a triangle.')
console.log('----------------------------------------------------------');

function Point(x, y) {
    this.x = x;
    this.y = y;
    this.toString = function () {
        return '(' + this.x + ',' + this.y + ')';
    }
}

function Line(firstPoint, secondPoint) {
    this.firstPoint = firstPoint;
    this.secondPoint = secondPoint;
    this.lineLength = function () {
        // http://math.info/Algebra/Distance_Cartesian_Plane/ 
        var distance = Math.sqrt(Math.pow((this.firstPoint.x - this.secondPoint.x), 2) + Math.pow((this.firstPoint.y - this.secondPoint.y), 2));
        return distance;
    }
    this.toString = function () {
        return '(P1' + firstPoint.toString() + ', P2' + secondPoint.toString() + ')';
    }
}

function isMakeTriangle(line_a, line_b, line_c) {
    var firstCondition = line_a.lineLength + line_b.lineLength > line_c.lineLength;
    var secondCondition = line_a.lineLength + line_c.lineLength > line_b.lineLength;
    var thirdCondition = line_b.lineLength + line_c.lineLength > line_a.lineLength;
    return firstCondition && secondCondition && thirdCondition;
}


var p1 = new Point(0, 5);
var p2 = new Point(1, 6);
var p3 = new Point(-2, 8);
var p4 = new Point(-3, -4);
var p5 = new Point(0, -7);
var p6 = new Point(9, -3);

var lineA = new Line(p1, p2);
var lineB = new Line(p3, p4);
var lineC = new Line(p5, p6);


jsConsole.writeLine('line A => L' + lineA.toString() + ' with distance between points ' + lineA.lineLength().toFixed(2) + ' units.');
jsConsole.writeLine('line B => L' + lineB.toString() + ' with distance between points ' + lineB.lineLength().toFixed(2) + ' units.');
jsConsole.writeLine('line C => L' + lineC.toString() + ' with distance between points ' + lineC.lineLength().toFixed(2) + ' units.');
console.log('line A => L' + lineA.toString() + ' with distance between points ' + lineA.lineLength().toFixed(2) + ' units.');
console.log('line B => L' + lineB.toString() + ' with distance between points ' + lineB.lineLength().toFixed(2) + ' units.');
console.log('line C => L' + lineC.toString() + ' with distance between points ' + lineC.lineLength().toFixed(2) + ' units.');

if (isMakeTriangle(lineA, lineB, lineC)) {
    jsConsole.writeLine('Can form triangle');
    console.log('Can form triangle');
}
else {
    jsConsole.writeLine("Can't form triangle");
    console.log("Can't form triangle");
}