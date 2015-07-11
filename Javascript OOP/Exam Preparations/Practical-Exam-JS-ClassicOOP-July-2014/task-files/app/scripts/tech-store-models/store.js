define(['tech-store-models/item'], function (Item) {

    var Store = (function () {
        var ITEM_NAME_MIN_LENGTH = 6,
            ITEM_NAME_MAX_LENGTH = 30,
            itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'],
            storeItems = [];

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

        function isValidType(param) {
            var isValid = itemTypes.some(function (item) {
                return item === param;
            });
            return isValid;
        }

        function Store(name) {
            this.name = setName(name);
        }

        function setName(value) {
            if (value.length < ITEM_NAME_MIN_LENGTH || value.length > ITEM_NAME_MAX_LENGTH) {
                throw new Error('Invalid name length');
            }
            return value;
        }

        Store.prototype = {
            addItem: function addItem(item) {
                if (!(item instanceof Item)) {
                    throw new Error('Parameter should be of type Item');
                }
                storeItems.push(item);
                return this;
            },
            getAll: function getAll() {
                var result = storeItems.slice();
                result.sort(alphabetical);
                return result;
            },
            getSmartPhones: function getSmartPhones() {
                var smartPhones = this.filterItemsByType('smart-phone');
                smartPhones.sort(alphabetical);
                return smartPhones;
            },
            getMobiles: function getMobiles() {
                var phones = this.getSmartPhones();
                var tablets = this.filterItemsByType('tablet');
                var result = phones.concat(tablets);
                result.sort(alphabetical);
                return result;
            },
            getComputers: function getComputers(params) {
                var pcs = this.filterItemsByType('pc');
                var notebooks = this.filterItemsByType('notebook');
                var result = pcs.concat(notebooks);
                result.sort(alphabetical);
                return result;
            },
            filterItemsByType: function filterItemsByType(value) {
                var collection;
                if (!isValidType(value)) {
                    throw new Error('Invalid filter item type');
                }

                collection = storeItems.reduce(function (arr, item) {
                    if (item.type === value) {
                        arr.push(item);
                    }
                    return arr;
                }, []);

                collection.sort(alphabetical);
                return collection;
            },
            filterItemsByPrice: function filterItemsByPrice(options) {
                var result;
                if (options === undefined) {
                    result = storeItems.slice().sort(function (item1, item2) {
                        return item1.price - item2.price;
                    });
                }
                else if (options.min === undefined && options.max) {
                    options.min = 0;
                    result = storeItems.reduce(function (arr, item) {
                        if (item.price > options.min && item.price < options.max) {
                            arr.push(item);
                        }
                        return arr;
                    }, []);
                    result.sort(function (item1, item2) {
                        return item1.price - item2.price;
                    });
                }
                else if (options.max === undefined && options.min) {
                    options.max = Infinity;
                    result = storeItems.reduce(function (arr, item) {
                        if (item.price > options.min && item.price < options.max) {
                            arr.push(item);
                        }
                        return arr;
                    }, []);
                    result.sort(function (item1, item2) {
                        return item1.price - item2.price;
                    });
                }
                else{
                   result = storeItems.reduce(function (arr, item) {
                        if (item.price > options.min && item.price < options.max) {
                            arr.push(item);
                        }
                        return arr;
                    }, []);
                    result.sort(function (item1, item2) {
                        return item1.price - item2.price;
                    });
                }
                return result;
            },
            countItemsByType: function countItemsByType() {
                var index, len, element,
                    dictionary = {};
                for (index = 0, len = storeItems.length; index < len; index += 1) {
                    element = storeItems[index];
                    if (!(dictionary.hasOwnProperty(element.type))) {
                        dictionary[element.type] = 0;
                    }
                    dictionary[element.type] += 1;
                }
                return dictionary;
            },
            filterItemsByName: function filterItemsByName(value) {
                var result = storeItems.filter(function (item) {
                    return item.name.toLowerCase().indexOf(value.toLowerCase()) >= 0;
                });
                result.sort(alphabetical);
                return result;
            }
            
        };

        return Store;
    } ());
    return Store;
});