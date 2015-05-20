/// <reference path="js-console.js"/>

//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 3: Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 3: Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.')
console.log('----------------------------------------------------------');


function cloneObject(obj) {
    if (typeof obj === 'number' || typeof obj === 'string') {
        return obj;
    }
    var clone = {};
    for (var i in obj) {
        if (typeof (obj[i]) === "object" && obj[i] !== null) {
            clone[i] = cloneObject(obj[i]);
        }
        else {
            clone[i] = obj[i];
        }
    }
    return clone;
}
var object =
    {
        date: {},
        number: 0,
        text: "",
        toString: function () {
            return '(date: ' + this.date.getDay() + ' ' + this.date.getMonth() + ' ' + this.date.getFullYear() + ', number: ' + this.number + ', text: ' + this.text + ')';
        },
        setDate: function d(day, month, year) {
            this.date = new Date(year, month , day)
        },
        increaseNumber: function (num) {
            this.number = this.number + num;
        }
    };

var copy = cloneObject(object);

object.setDate(12, 11, 2014);
object.number = 120;
object.increaseNumber(3);
object.text = 'This is original object';

copy.setDate(12, 11, 2014);
copy.number = 120;
copy.text = 'This is clone object';

jsConsole.writeLine(object.toString());
jsConsole.writeLine(copy.toString());
console.log(object.toString());
console.log(copy.toString());

var number = 99;
var copyNumber = cloneObject(number);
jsConsole.writeLine(number);
jsConsole.writeLine(copyNumber);
console.log(number);
console.log(copyNumber);


