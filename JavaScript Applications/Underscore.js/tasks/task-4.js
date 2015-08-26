/* 
Create a function that:
*   **Takes** an array of animals
    *   Each animal has propeties `name`, `species` and `legsCount`
*   **groups** the animals by `species`
    *   the groups are sorted by `species` descending
*   **sorts** them ascending by `legsCount`
	*	if two animals have the same number of legs sort them by name
*   **prints** them to the console in the format:

```
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    GROUP_1_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_1_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in group 1
    NAME has LEGS_COUNT legs //for the second animal in group 1
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    GROUP_2_NAME:
    ----------- (number of dashes is equal to the length of the GROUP_2_NAME + 1)
    NAME has LEGS_COUNT legs //for the first animal in the group 2
    NAME has LEGS_COUNT legs //for the second animal in the group 2
    NAME has LEGS_COUNT legs //for the third animal in the group 2
    NAME has LEGS_COUNT legs //for the fourth animal in the group 2
```
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

        result = _.chain(animals)
            .groupBy('species')
            .map(function (groupBySpecies) {
                var group = {
                    groupName: groupBySpecies[0].species,
                    animals: groupBySpecies
                };
                return group;
            })
            .sortBy('groupName')
            .reverse()
            .each(function (animalsGroup, index, list) {
                var speciesName = animalsGroup.groupName + ':';
                console.log((new Array(speciesName.length + 1).join('-')));
                console.log(speciesName);
                console.log((new Array(speciesName.length + 1).join('-')));
                _.chain(animalsGroup.animals)
                    .sortBy(function(animal){
                        return [animal.legsCount, animal.name];
                    })
                    .each(function (animal) {
                        console.log(animal.name + ' has ' + animal.legsCount + ' legs');
                    })
            });
    };
}

module.exports = solve;
