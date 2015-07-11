define([], function () {

    var validator = {
        string: {
            isNullOrEmpty: function (value, message) {
                if (value === undefined || value === null || value.length === 0) {
                    throw new Error(message);
                }
            },
            isValidLength: function (value, min, max, message) {
                this.isNullOrEmpty(value, message);
                validator.number.isValidRange(value.length, min, max, message);
            }
        },
        array: {
            isNullOrEmpty: function (value, message) {
                validator.string.isNullOrEmpty(value, message);
            }
        },
        number: {
            isPositive: function (value, message) {
                var parse = this.isInt(value) ? parseInt : parseFloat;
                if (value === undefined || isNaN(parse(value)) || value < 0) {
                    throw new Error(message);
                }
            },
            isValidRange: function (value, min, max, message) {
                var parse = this.isInt(value) ? parseInt : parseFloat;
                if (value === undefined || isNaN(parse(value)) || (min > value || value > max)) {
                    throw new Error(message);
                }
            },
            isInt: function isInt(value) {
                return Number(value) === value && value % 1 === 0;
            },
            isFloat: function isFloat(value) {
                return value === Number(value) && value % 1 !== 0;
            }
        }
    };

    var item = (function () {
        var ITEM_NAME_MIN_LENGTH = 6,
            ITEM_NAME_MAX_LENGTH = 40,
            itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

        function validateType(value) {
            var isValidType = itemTypes.some(function (t) {
                return t === value;
            });

            if (!isValidType) {
                throw new Error('Invalid Item type');
            }
            return value;
        }


        var item = {};

        Object.defineProperties(item, {
            init: {
                value: function (itemType, itemName, itemPrice) {
                    this.type = itemType;
                    this.name = itemName;
                    this.price = itemPrice;
                    return this;
                }
            },
            name: {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.string.isNullOrEmpty(value, 'Item name is null or empty');
                    validator.string.isValidLength(value, ITEM_NAME_MIN_LENGTH, ITEM_NAME_MAX_LENGTH, 'Invalid name length');
                    this._name = value;
                },
                enumerable: true,
                configurable: true
            },
            type: {
                get: function () {
                    return this._type;
                },
                set: function (value) {
                    this._type = validateType(value);
                }
            },
            price: {
                get: function () {
                    return this._price;
                },
                set: function (value) {
                    if (!validator.number.isFloat(value)) {
                        throw new Error('Invalid Item price');
                    }
                    this._price = value;
                }
            }
        })

        return item;
    } ());
    return item;
});