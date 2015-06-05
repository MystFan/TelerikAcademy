/// <reference path="persons.js"/>
//Problem 5. Youngest person

//Write a function that finds the youngest male person in a given array of people and prints his full name
//    Use only array methods and no regular loops (for, while)
//    Use Array#find

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i, len = this.length;
        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this)) {
                return this[i];
            }
        }
    }
}

var minAge = persons.reduce(function (minAge, person) {
    if (minAge > person.age) {
        minAge = person.age;
    }
    return minAge;
}, 100);

var youngestPerson = persons.find(function (person) {
    return person.age === minAge;
});

console.log('Problem 5:');
console.log(youngestPerson);
jsConsole.writeLine('Problem 5:');
jsConsole.writeLine('Yongest person: ' + youngestPerson);
