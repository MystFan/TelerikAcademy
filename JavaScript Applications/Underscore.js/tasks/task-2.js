/*
Create a function that:
*   Takes an array of students
    *   Each student has a `firstName`, `lastName` and `age` properties
*   **finds** the students whose age is between 18 and 24
*   **prints**  the fullname of found students, sorted lexicographically ascending
    *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
*   **Use underscore.js for all operations**
*/

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
        var result,
            constans = {
                MIN_AGE: 18,
                MAX_AGE: 24
            };
        validator.validateIfArray(students);

        _.each(students, function (student) {
            validator.validateIfUndefined(student, 'Student');
            validator.validateString(student.firstName, 0, Number.MAX_VALUE, 'Student first name');
            validator.validateString(student.lastName, 0, Number.MAX_VALUE, 'Student last name');
            validator.validateIfNumber(student.age, 'Student age');
        });

       result = _.chain(students)
            .filter(function (student) {
                return constans.MIN_AGE <= student.age && student.age <= constans.MAX_AGE;
            })
            .map(function(student){
                student.fullName = student.firstName + ' ' + student.lastName;
                return student;
            })
            .sortBy(function(student) {
                return student.fullName;
            })
            .each(function (student) {
                console.log(student.fullName)
            });
    };
}

module.exports = solve;
