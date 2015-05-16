console.log('--------------------------------------------------------------------------------');
console.log('//Problem 1: Assign all the possible JavaScript literals to different variables.');
console.log('--------------------------------------------------------------------------------');
console.log('//Integer literals');
var number = 12;
console.log(number);
number = -13;
console.log(number);
number = 0x1123;
console.log(number);
number = -0xF1A7;
console.log(number);
number = -077;
console.log(number);
number = 007;
console.log(number);

console.log('//Strings literals');
var str = "Pesho";
console.log(str);
str = 'Pesho';
console.log(str);
str = "1234";
console.log(str);
str = '1234';
console.log(str);
str = 'first row \n second row';
console.log(str);
str = "Pesho's car";
console.log(str);

console.log('//Boolean literals');
var swich = true;
console.log(swich);
swich = false;
console.log(swich);

console.log('//floating-point literals');
var floatPoint = 23.45;
console.log(floatPoint);
floatPoint = .33333333;
console.log(floatPoint);
floatPoint = -.5;
console.log(floatPoint);

console.log('//object literals');
var obj = function () { };
console.log(obj);
var dog = {
    legs: 4,
    breed: 'huski'
};
console.log(dog.breed);
console.log(dog.legs);
var car = {
    Cars:
        {
            a: "Saab",
            "b": "Jeep"
        },
    7: "Mazda"
};
console.log(car.Cars.b);
console.log(car[7]);

function Person() {
    return "Pesho";
}
console.log(Person());
obj = [];
console.log(obj);
obj = {};
console.log(obj);