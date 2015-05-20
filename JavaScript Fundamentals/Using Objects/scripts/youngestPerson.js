/// <reference path="js-console.js"/>

//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 5: Write a function that finds the youngest person in a given array of people and prints his/hers full name.Each person has properties firstname, lastname and age.')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 5: Write a function that finds the youngest person in a given array of people and prints his/hers full name.Each person has properties firstname, lastname and age.')
console.log('----------------------------------------------------------');

var persons = [
      { firstname: "Gosho", lastname: "Petrov", age: 32 },
      { firstname: "Ivan", lastname: "Petrov", age: 21 },
      { firstname: "Pesho", lastname: "Petrov", age: 29 },
      { firstname: "Pesho", lastname: "Peshev", age: 25 },
      { firstname: "Velichko", lastname: "Dimitrov", age: 59 },
      { firstname: "Ivan", lastname: "Ivanov", age: 52 },
      { firstname: "Maria", lastname: "Shpricova", age: 43 },
      { firstname: "Nikolai", lastname: "Aleksiev", age: 53 },
      { firstname: "Aleksander", lastname: "Aleksiev", age: 22 },
      { firstname: "Maria", lastname: "Bakarjieva", age: 52 },
];

function youngestPerson(persons) {
    var i, youngest = persons[0];

    for (i = 0; i < persons.length; i++) {
        if (youngest.age > persons[i].age) {
            youngest = persons[i];
        }
    }
    return youngest;
}

var youngestPerson = youngestPerson(persons);
jsConsole.writeLine("Youngest person: " + youngestPerson.firstname + ' ' + youngestPerson.lastname);
console.log("Youngest person: " + youngestPerson.firstname + ' ' + youngestPerson.lastname);