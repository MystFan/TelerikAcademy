/// <reference path="js-console.js"/>

//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)

jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 6: Write a function that groups an array of people by age, first or last name.The function must return an associative array, with keys - the groups, and values - arrays with people in this groups.Use function overloading (i.e. just one function).')
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 6: Write a function that groups an array of people by age, first or last name. The function must return an associative array, with keys - the groups, and values - arrays with people in this groups.Use function overloading (i.e. just one function).');
console.log('----------------------------------------------------------');


var people = [
    { firstname: 'Gosho', lastname: 'Petrov', age: 32 },
    { firstname: 'Losho', lastname: 'Petrov', age: 32 },
    { firstname: 'Ivan', lastname: 'Petrov', age: 22 },
    { firstname: 'Pesho', lastname: 'Petrov', age: 29 },
    { firstname: 'Pesho', lastname: 'Peshev', age: 22 },
    { firstname: 'Velichko', lastname: 'Dimitrov', age: 59 },
    { firstname: 'Ivan', lastname: 'Ivanov', age: 52 },
    { firstname: 'Maria', lastname: 'Shpricova', age: 43 },
    { firstname: 'Nikolai', lastname: 'Aleksiev', age: 52 },
    { firstname: 'Aleksander', lastname: 'Aleksiev', age: 22 },
    { firstname: 'Maria', lastname: 'Peshev', age: 52 },
];
function group(collection, propName) {

    switch (propName) {
        case 'firstname': return groupByFirstName(collection); break;
        case 'lastname': return groupByLastName(collection); break;
        case 'age': return groupByAge(collection); break;
    }

    function groupByAge(arr) {
        var groupAge = [];
        var age, i;

        for (i = 0; i < arr.length; i++) {

            age = arr[i].age.toString();
            if (!groupAge[age]) {
                groupAge[age] = [];
            }

            groupAge[age].push(arr[i]);
        }

        return groupAge;
    }

    function groupByFirstName(arr) {
        var groupFirstName = [];
        var firstName, i;

        for (i = 0; i < arr.length; i++) {

            firstName = arr[i].firstname;
            if (!groupFirstName[firstName]) {
                groupFirstName[firstName] = [];
            }

            groupFirstName[firstName].push(arr[i]);
        }
        return groupFirstName;
    }

    function groupByLastName(arr) {
        var groupLastName = [];
        var lastName, i;

        for (i = 0; i < arr.length; i++) {

            lastName = arr[i].lastname;
            if (!groupLastName[lastName]) {
                groupLastName[lastName] = [];
            }

            groupLastName[lastName].push(arr[i]);
        }
        return groupLastName;
    }
}

var personsByAge;
personsByAge = group(people, 'age');
jsConsole.writeLine('Group by Age:');
console.log('Group by Age:')
printGroup(personsByAge);

var personsByFirstName;
personsByFirstName = group(people, "firstname");
jsConsole.writeLine("Group by First Name:");
console.log("Group by First Name:");
printGroup(personsByFirstName);

var personByLastName;
personByLastName = group(people, "lastname");
jsConsole.writeLine("Group by Last Name:");
console.log("Group by Last Name:");
printGroup(personByLastName);

function printGroup(collection) {
    var keys = Object.keys(collection);
    for (var j = 0; j < keys.length; j++) {
        for (var i = 0; i < collection[keys[j]].length; i++) {
            jsConsole.writeLine(keys[j] + " -> " + collection[keys[j]][i].firstname + ' ' + collection[keys[j]][i].lastname);
            console.log(keys[j] + " -> " + collection[keys[j]][i].firstname + ' ' + collection[keys[j]][i].lastname);
        }
        jsConsole.writeLine('---------------');
        console.log('---------------');
    }
}