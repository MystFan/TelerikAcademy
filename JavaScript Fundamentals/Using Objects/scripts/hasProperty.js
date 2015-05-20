/// <reference path="js-console.js"/>

//Problem 4. Has property
//Write a function that checks if a given object contains a given property.

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 4: Write a function that checks if a given object contains a given property.')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 4: Write a function that checks if a given object contains a given property.')
console.log('----------------------------------------------------------');

function Car(type, maxSpeed, engineType) {
    this.type = type;
    this.maxSpeed = maxSpeed;
    this.engineType = engineType;
}

function hasProperty(obj, prop) {
    var hasProp = false;
    if (typeof obj === 'object' && obj !== null) {
        if (obj.hasOwnProperty(prop)) {
            hasProp = true;
        }
    }
    else {
        throw new 'Object must be reference type';
    }
    return hasProp;
}

var car = new Car('coupe', 240, 'gas');

var hasProp = hasProperty(car, 'type');

jsConsole.writeLine(hasProp);
console.log(hasProp);
