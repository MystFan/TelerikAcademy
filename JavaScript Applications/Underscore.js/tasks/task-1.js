
/* 
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName` and `lastName` properties
*   **Finds** all students whose `firstName` is before their `lastName` alphabetically
*   Then **sorts** them in descending order by fullname
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   Then **prints** the fullname of founded students to the console
*   **Use underscore.js for all operations**
*/
///</// <reference path="./typing/underscore/underscore.d.ts" />

function solve() {
    var validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined');
            }
        },
        validateIfObject: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'object') {
                throw new Error(name + ' must be an object');
            }
        },
        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number');
            }
        },
        validateString: function (val, minLength, maxLength, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < minLength || maxLength < val.length) {
                throw new Error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols');
            }
        },
        validatePositiveNumber: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfNumber(val, name);

            if (val <= 0) {
                throw new Error(name + ' must be positive number');
            }
        },
        validateIfArray: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfObject(val, name);

            if (!Array.isArray(val)) {
                throw new Error(name + ' must be array');
            }
        }
    };

    return function (students) {
        var result;
        validator.validateIfArray(students);

        _.each(students, function (student) {
            validator.validateIfUndefined(student, 'Student');
            validator.validateString(student.firstName, 0, Number.MAX_VALUE, 'Student first name');
            validator.validateString(student.lastName, 0, Number.MAX_VALUE, 'Student last name');
        });

        result = _.chain(students)
            .map(function (student) {
                student.fullName = student.firstName + ' ' + student.lastName;
                return student;
            })
            .filter(function (student) {
                return student.firstName < student.lastName
            })
            .sortBy(function (student) {
                return student.fullName;
            })
            .reverse()
            .each(function(student){
                 console.log(student.fullName);
            });
    };
}

module.exports = solve;