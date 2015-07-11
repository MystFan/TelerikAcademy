define(['tech-store-models/item'], function (item) {
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
    var store = (function () {
        var STORE_NAME_MIN_LENGTH = 6,
            STORE_NAME_MAX_LENGTH = 30,
            itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'],
            storeItems = [];

        function validateType(value) {
            var isValidType = itemTypes.some(function (t) {
                return t === value;
            });

            if (!isValidType) {
                throw new Error('Invalid Item type');
            }
        }

        function alphabetical(a, b) {
            var A = a.name.toLowerCase();
            var B = b.name.toLowerCase();
            if (A < B) {
                return -1;
            } else if (A > B) {
                return 1;
            } else {
                return 0;
            }
        };

        var store = {};

        Object.defineProperties(store, {
            init: {
                value: function (name) {
                    this.name = name;
                    return this;
                }
            },
            name: {
                get: function () {
                    return this._name;
                },
                set: function (value) {
                    validator.string.isNullOrEmpty(value, 'Store name is null or empty');
                    validator.string.isValidLength(value, STORE_NAME_MIN_LENGTH, STORE_NAME_MAX_LENGTH, 'Invalid store name length');
                    this._name = value;
                }
            },
            addItem: {
                value: function (inputItem) {
                    if (!item.isPrototypeOf(inputItem)) {
                        throw new Error('Value is not a Item');
                    }
                    storeItems.push(inputItem);
                    return this;
                }
            },
            getAll: {
                value: function () {
                    var allItems = storeItems.slice();
                    allItems.sort(alphabetical);
                    return allItems;
                }
            },
            filterItemsByType: {
                value: function (itemType) {
                    validateType(itemType);
                    var result = storeItems.filter(function (item) {
                        return item.type === itemType;
                    });

                    result.sort(alphabetical);
                    return result;
                }
            },
            getSmartPhones: {
                value: function () {
                    var result = this.filterItemsByType('smart-phone');
                    return result;
                }
            },
            getMobiles: {
                value: function () {
                    var smartPhones = this.filterItemsByType('smart-phone');
                    var tablets = this.filterItemsByType('tablet');
                    return smartPhones.concat(tablets);
                }
            },
            getComputers: {
                value: function () {
                    var pcs = this.filterItemsByType('pc');
                    var notebooks = this.filterItemsByType('notebook');
                    return pcs.concat(notebooks);
                }
            },
            filterItemsByPrice: {
                value: function (options) {
                    var result;
                    if (!options) {
                        result = storeItems.slice();
                    } else if ((!options.min) && options.max) {
                        result = storeItems.filter(function (item) {
                            return item.price > 0 && item.price <= options.max;
                        });
                    } else if (options.min && (!options.max)) {
                        result = storeItems.filter(function (item) {
                            return item.price > options.min;
                        });
                    } else {
                        result = storeItems.filter(function (item) {
                            return item.price > options.min && item.price < options.max;
                        });
                    }

                    result.sort(alphabetical);
                    return result;
                }
            },
            countItemsByType: {
                value: function () {
                    var dictionary = {};
                    for (var index = 0; index < storeItems.length; index += 1) {
                        var element = storeItems[index];
                        if (!dictionary.hasOwnProperty(element.type)) {
                            dictionary[element.type] = 0;
                        }

                        dictionary[element.type] += 1;
                    }

                    return dictionary;
                }
            },
            filterItemsByName: {
                value: function (partOfName) {
                    var result = storeItems.filter(function(item){
                        return item.name.toLowerCase().indexOf(partOfName.toLowerCase()) >= 0;
                    })
                    result.sort(alphabetical);
                    return result;
                }
            }
        })

        return store;
    } ());
    return store;
});