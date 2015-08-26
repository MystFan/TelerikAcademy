/* 
Create a function that:
*   Takes an array of students
    *   Each student has:
        *   `firstName`, `lastName` and `age` properties
        *   Array of decimal numbers representing the marks         
*   **finds** the student with highest average mark (there will be only one)
*   **prints** to the console  'FOUND_STUDENT_FULLNAME has an average score of MARK_OF_THE_STUDENT'
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
        var studentWithHighestAverageMark, compiledTemplate, result;
        validator.validateIfArray(students);

        _.each(students, function (student) {
            validator.validateIfUndefined(student, 'Student');
            validator.validateString(student.firstName, 0, Number.MAX_VALUE, 'Student first name');
            validator.validateString(student.lastName, 0, Number.MAX_VALUE, 'Student last name');
            validator.validateIfNumber(student.age, 'Student age');
            validator.validateIfArray(student.marks, 'Student marks');
            _.each(student.marks, function (mark) {
                validator.validateIfNumber(mark, 'Student mark');
            })
        });

        studentWithHighestAverageMark = _.chain(students)
            .map(function (student) {
                var sumOfMarks = _.reduce(student.marks, function (sum, mark) {
                    return sum + mark;
                }, 0);  
                student.averageMarks = sumOfMarks / student.marks.length;
                return student;
            })
            .sortBy(function (student) {
                return student.averageMarks;
            })
            .reverse()
            .first()
            .value();
            
        compiledTemplate = _.template("<%= firstName %> <%= lastName %> has an average score of <%= averageMarks %>");
        result = compiledTemplate(studentWithHighestAverageMark);
        console.log(result);
    };
}

module.exports = solve;
