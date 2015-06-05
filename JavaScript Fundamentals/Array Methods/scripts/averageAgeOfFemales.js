/// <reference path="persons.js"/>
//Problem 4. Average age of females

//Write a function that calculates the average age of all females, extracted from an array of persons
//    Use Array#filter
//    Use only array methods and no regular loops (for, while)


var averageAgeOfFemales = persons.filter(function (person) {
    return person.gender;
});

var sum = averageAgeOfFemales.reduce(function (sum, female) {
    return sum + female.age;
}, 0);

var avg = sum / averageAgeOfFemales.length;

console.log('Problem 4:');
console.log('Female average age: ' + avg);
jsConsole.writeLine('Problem 4:');
jsConsole.writeLine('Female average age: ' + avg);