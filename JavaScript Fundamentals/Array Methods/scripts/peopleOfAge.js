/// <reference path="persons.js"/>

//Problem 2. People of age

//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//    Use only array methods and no regular loops (for, while)

var peopleOfAge = persons.filter(function (person) {
    return person.age >= 18;
});

jsConsole.writeLine("Problem 2:");
jsConsole.writeLine(peopleOfAge.join(', '));
console.log("Problem 2:");
console.log(peopleOfAge);