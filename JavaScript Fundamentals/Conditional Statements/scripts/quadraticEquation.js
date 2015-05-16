
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 6: Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).Calculates and prints its real roots.Note: Quadratic equations may have 0, 1 or 2 real roots.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 6: Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).Calculates and prints its real roots.Note: Quadratic equations may have 0, 1 or 2 real roots.');
console.log('-------------------------------------------------------------------------------');

function quadraticEquation() {
    var a = document.getElementById('tb-first').value - 0;
    var b = document.getElementById('tb-second').value - 0;
    var c = document.getElementById('tb-third').value - 0;

    if (isNaN(a) || isNaN(b) || isNaN(c)) {
        jsConsole.writeLine('Invalid input number.');
        console.log('Invalid input number.');
        return;
    }

    if (a !== 0) {
        var D = Math.pow(b, 2) - (4 * a * c);
        if (D > 0) {
            var x1 = (-b - Math.sqrt(D)) / (2 * a);
            var x2 = (-b + Math.sqrt(D)) / (2 * a);
            jsConsole.writeLine('Quadratic equation have two real roots');
            jsConsole.writeLine('x1= ' + x1);
            jsConsole.writeLine('x2= ' + x2);
            console.log('Quadratic equation have two real roots');
            console.log('x1 = ' + x1);
            console.log('x2 = ' + x2);
        }
        if (D === 0) {
            var x = (-b) / (2 * a);
            jsConsole.writeLine('Quadratic equation have one real root x1 = x2 = ' + x);
            console.log('Quadratic equation have one real root x1 = x2 = ' + x);
        }
        if (D < 0) {
            jsConsole.writeLine("Quadratic equation has no real roots.");
            console.log("Quadratic equation has no real roots.");
        }
    }
    else {
        jsConsole.writeLine("Quadratic equation has no solution.");
        console.log("Quadratic equation has no solution.");
    }
}