//Problem 1. Format with placeholders

//    Write a function that formats a string. The function should have placeholders, as shown in the example
//        Add the function to the String.prototype

if (!String.prototype.format) {
    String.prototype.format = function (options) {
        if((!(options instanceof Object)) || Array.isArray(options)){
            throw 'Parameter must be of type object';
        }
        var i, len, pattern,
            result = this,
            keys = Object.keys(options);

        for (i = 0, len = keys.length; i < len; i+=1) {
            pattern = new RegExp('#{' + keys[i] + '}', 'g');
            result = result.replace(pattern, options[keys[i]]);
        }
        return result;
    };
}

console.log('Problem 1:');
var firstOptions = { name: 'John' };
console.log('Hello, there! Are you #{name}?'.format(firstOptions));
var secondOptions = { name: 'John', age: 13 };
console.log('My name is #{name} and I am #{age}-years-old'.format(secondOptions));
