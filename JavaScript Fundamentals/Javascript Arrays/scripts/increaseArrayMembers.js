jsConsole.writeLine('--------------------------------------------------------------------');
jsConsole.writeLine('Problem 1: Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.Print the obtained array on the console.')
jsConsole.writeLine('--------------------------------------------------------------------');
console.log('--------------------------------------------------------------------');
console.log('Problem 1: Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5.Print the obtained array on the console.')
console.log('--------------------------------------------------------------------');


var arr = new Array(20);

for (var i = 0; i < arr.length; i++) {
    arr[i] = i * 5;
}

jsConsole.writeLine(arr.join(", "));
console.log(arr.join(", "));