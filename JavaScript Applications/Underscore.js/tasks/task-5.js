/* 
 Create a function that:
 *   **Takes** an array of animals
 *   Each animal has propeties `name`, `species` and `legsCount`
 *   **finds** and **prints** the total number of legs to the console in the format:
 *   "Total number of legs: TOTAL_NUMBER_OF_LEGS"
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
    return function (animals) {
        var result;
        validator.validateIfArray(animals, 'Animals');
        _.each(animals, function (animal) {
            validator.validateIfUndefined(animal, 'Animal');
            validator.validateString(animal.name, 0, Number.MAX_VALUE, 'Animal name');
            validator.validateString(animal.species, 0, Number.MAX_VALUE, 'Animal species');
            validator.validatePositiveNumber(animal.legsCount, 'Animal legs count');
        });

        result = _.reduce(animals, function (sum, animal) {
            return sum + animal.legsCount;
        }, 0);
        console.log('Total number of legs: ' + result);
    };
}

module.exports = solve;
