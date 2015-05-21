//Problem 12. Generate list

//Write a function that creates a HTML <ul> using a template for every HTML <li>.
//The source of the list should be an array of elements.
//Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

print('Problem 12: Write a function that creates a HTML <ul> using a template for every HTML <li>.The source of the list should be an array of elements.Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.');

var persons = [
    { name: "Gosho", age: 32 },
    { name: "Losho", age: 32 },
    { name: "Ivan", age: 21 },
    { name: "Pesho", age: 29 },
    { name: "Pesho", age: 25 },
    { name: "Velichko", age: 59 },
    { name: "Ivan", age: 52 },
    { name: "Maria", age: 43 },
    { name: "Nikolai", age: 53 },
    { name: "Aleksander", age: 22 },
    { name: "Maria", age: 52 },
];
var tmpl = document.getElementById("list-item").innerHTML;
console.log(tmpl.trim());

function getTemplateKeys(template) {
    var placeHolderStartIndex = -1;
    var placeHolderEndIndex = -1;
    var keys = [];
    while (true) {
        placeHolderStartIndex = template.indexOf('-{', placeHolderStartIndex + 1);
        placeHolderEndIndex = template.indexOf('}-', placeHolderEndIndex + 1);
        if (placeHolderStartIndex < 0 || placeHolderEndIndex < 0) {
            break;
        }
        keys.push(template.substring(placeHolderStartIndex + 2, placeHolderEndIndex));
    }
    return keys;
}

function generateList(people, template) {
    var htmlKeys = getTemplateKeys(template);
    var peopleList = '';
    var list = '<li>...</li>';
    var li = [];
    var current = '';

    for (var i = 0; i < people.length; i++) {
        current = template.trim();
        for (var j = 0; j < htmlKeys.length; j++) {
            current = (current.replace('-{' + htmlKeys[j] + '}-', people[i][htmlKeys[j]]));
        }
        li.push(list.replace('...', current));
        current = '';
    }

    for (var i = 0; i < li.length; i++) {
        peopleList = peopleList + '    ' + li[i] + '\n';
    }
    peopleList = '<ul>\n' + peopleList + '</ul>';
    return peopleList;
}

console.log(generateList(persons, tmpl));
jsConsole.writeLine(generateList(persons, tmpl));
