/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
    var Course = (function () {

        function getUniqueSudentsResults(results) {
            var n = {}, result = [];
            for (var i = 0; i < results.length; i+=1) {
                if (!n[results[i].StudentID]) {
                    n[results[i].StudentID] = true;
                    result.push(results[i]);
                }
            }
            return result;
        }

        function validateCourseTitle(title) {
            if (typeof (title) === 'undefined') {
                throw new Error('Course title is undefined');
            }
            if (typeof (title) !== 'string') {
                throw new Error('Course title must be string');
            }
            if (title[0] === ' ' || title[title.length - 1] === ' ') {
                throw new Error('Invalid Course title');
            }
            return title;
        }

        function validateResults(course, results) {
            if (typeof (results) == 'undefined') {
                throw new Error('Students results is undefined');
            }
            if (!Array.isArray(results)) {
                throw new Error('Students results must be array');
            }
            results.forEach(function (result) {
                if (typeof (result) == 'undefined') {
                    throw new Error('Student result is undefined');
                }
                if (typeof (result) !== 'object') {
                    throw new Error('Student result must be object');
                }
                if (!result.hasOwnProperty('StudentID') || !result.hasOwnProperty('Score')) {
                    throw new Error('Invalid student result');
                }
                if (result.StudentID <= 0 || result.StudentID > course.students.length) {
                    throw new Error('Invalid student id');
                }
                if (typeof (result.Score) !== 'number' || typeof (result.StudentID) !== 'number') {
                    throw new Error('Student score or id is not a number');
                }
            });
            
            if(getUniqueSudentsResults(results).length !== course.students.length){
                throw new Error('More than one result with same student id');
            }
        }
        function validatePresentations(value) {
            var isValidTitles;
            if (value === undefined) {
                throw new Error('Presentations is undefined');
            }
            if (!Array.isArray(value)) {
                throw new Error('Presentations must be array');
            }
            if (!value.length) {
                throw new Error('Presentations array is empty');
            }

            isValidTitles = value.every(function (title) {
                return isValidPresentationTitle(title);
            });

            if (!isValidTitles) {
                throw new Error('Invalid presentation title');
            }
            return value;
        }

        function isValidPresentationTitle(title) {
            var isValid = true;
            if (!title.length) {
                isValid = false;
            }
            if (title.indexOf('  ') >= 0) {
                isValid = false;
            }

            return isValid;
        }

        function validateStudentName(name) {

            if (typeof (name) === 'undefined') {
                throw new Error('Student name is undefined');
            }
            if (typeof (name) !== 'string') {
                throw new Error('Student name must be string');
            }
            if (name.match(/ /g).length > 1) {
                throw new Error('Invalid student name');
            }
            return name;
        }

        var Student = (function () {

            function isValidName(value) {
                var namePattern = /^[A-Z][a-z]*/g;
                if (!namePattern.test(value)) {
                    throw new Error('Invalid student name');
                }
                return value;
            }
            var Student = {
                init: function (firstname, lastname, id) {
                    this.firstname = firstname;
                    this.lastname = lastname;
                    this.id = id;
                    return this;
                },
                get id() {
                    return this._id;
                },
                set id(value) {
                    this._id = value;
                }
            };

            Object.defineProperty(Student, 'firstname', {
                get: function () {
                    return this._firstname;
                },
                set: function (value) {
                    this._firstname = isValidName(value);
                    return this;
                }
            });
            
            Object.defineProperty(Student, 'lastname', {
                get: function () {
                    return this._lastname;
                },
                set: function (value) {
                    this._lastname = isValidName(value);
                    return this;
                }
            });
            
            return Student;
        } ());


        var Course = {
            init: function (title, presentations) {
                this.presentations = presentations;
                this.title = title;
                this.students = [];
                return this;
            },
            addStudent: function (name) {
                var studentName = validateStudentName(name);
                var names = studentName.split(' ');
                var student = Object.create(Student).init(names[0], names[1], this.students.length + 1);
                this.students.push(student);
                return student.id;
            },
            getAllStudents: function () {
                return this.students.slice();
            },
            submitHomework: function (studentID, homeworkID) {
                if (studentID < 1 || studentID > this.students.length) {
                    throw new Error('Invalid student id');
                }
                if (homeworkID < 1 || homeworkID > this.presentations.length) {
                    throw new Error('Invalid homework id');
                }
            },
            pushExamResults: function (results) {
                validateResults(this, results);
                for (var index = 0, len = this.students.lenght.length; index < len; index+=1) {
                    var result = results.filter(function (r) {
                        return r.SudentID === this.students[index].id;
                    })[0];
                    
                    this.students[index].Score = result.Score;
                }
            },
            getTopStudents: function () {
                
            },
            get presentations() {
                return this._presentations.slice();
            },
            set presentations(value) {
                this._presentations = validatePresentations(value);
            },
            get students() {
                return this._students;
            },
            set students(value) {
                this._students = value;
            }
        };

        Object.defineProperty(Course, 'title', {
            get: function () {
                return this._title;
            },
            set: function (value) {
                this._title = validateCourseTitle(value);
                return this;
            }
        });

        return Course;
    } ());

    return Course;
}
var Course = solve();
var id, jsoop = Object.create(Course);

module.exports = solve;
