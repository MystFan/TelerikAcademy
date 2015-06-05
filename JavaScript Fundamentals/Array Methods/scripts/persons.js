//Problem 1. Make person

//Write a functio for creating persons.
//    Each person must have firstname, lastname, age and gender (true is female, false is male)
//Generate an array with ten person with different names, ages and genders
(function () {
    function Person(fName, lName, age, gender) {
        this.firstname = fName;
        this.lastname = lName;
        this.age = age;
        this.gender = gender;
        this.toString = function () {
            return '(' + this.firstname + ' ' + this.lastname + ', Age: ' + this.age + ', Gender: ' + (this.gender ? 'female' : 'male') + ')';
        }
    }

    var maleFirstNames = ["Niki", "Doncho", "Pesho", "Stamat", "Ivan", "Ivo", "Gosho"];
    var maleLastNames = ["Kostov", "Minkov", "Peshev", "Ivanov", "Stamatov", "Popov", "Kenov"];

    var femaleFirstNames = ["Maria", "Nikol", "Violeta", "Lara", "Ani"];
    var femaleLastNames = ["Kostova", "Minkova", "Pesheva", "Ivanova", "Kenova"];

    // global scope variable
    persons = [];
    persons.push(new Person('Gosho', 'Goshev', 14, false));

    for (var i = 0, len = maleFirstNames.length; i < len; i += 1) {
        var firstName = maleFirstNames[getRandomInt(0, 7)];
        var lastName = maleLastNames[getRandomInt(0, 7)];
        var personAge = getRandomInt(16, 30);
        var personGender = false;
        var person = new Person(firstName, lastName, personAge, personGender);
        persons.push(person);
    }

    for (var i = 0, len = femaleFirstNames.length; i < len; i += 1) {
        var firstName = femaleFirstNames[getRandomInt(0, 5)];
        var lastName = femaleLastNames[getRandomInt(0, 5)];
        var personAge = getRandomInt(16, 25);
        var personGender = true;
        var person = new Person(firstName, lastName, personAge, personGender);
        persons.push(person);
    }


    jsConsole.writeLine('Problem 1:')
    jsConsole.writeLine(persons.join(', '));
    console.log('Problem 1:');
    console.log(persons);

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min)) + min;
    }
}());
