/// <reference path="persons.js"/>
//Problem 6. Group people

//Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
//    Use Array#reduce
//    Use only array methods and no regular loops (for, while)

persons.sort();

var groups = persons.reduce(function (group, person) {
    var firstLetter = person.firstname[0].toLowerCase();
    if (!group.hasOwnProperty(firstLetter)) {
        group[firstLetter] = [];
    }
    group[firstLetter].push(person);
    return group;
}, {});

console.log('Problem 6:');
console.log(groups);
jsConsole.writeLine('Problem 6:')
jsConsole.writeLine(JSON.stringify(groups));