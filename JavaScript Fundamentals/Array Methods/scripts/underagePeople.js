/// <reference path="persons.js"/>

//Problem 3. Underage people

//Write a function that prints all underaged persons of an array of person
//    Use Array#filter and Array#forEach
//    Use only array methods and no regular loops (for, while)

var underagePeople = persons.filter(function (person) {
    return person.age < 18;
});

console.log('Problem 3:');
jsConsole.writeLine('Problem 3:');

underagePeople.forEach(function (person) {
    console.log(person.toString());
    jsConsole.writeLine(person);
});