define([], function () {

    var Item = (function () {
        var ITEM_NAME_MIN_LENGTH = 6,
            ITEM_NAME_MAX_LENGTH = 40,
            itemTypes = ['accessory', 'smart-phone', 'notebook', 'pc', 'tablet'];

        function isFloat(n) {
            return n === Number(n) && n % 1 !== 0;
        }

        function Item(itemType, itemName, itemPrice) {
            this.type = setType(itemType);
            this.name = setName(itemName);
            this.price = setPrice(itemPrice);
        }

        function setName(value) {
            if (value.length < ITEM_NAME_MIN_LENGTH || value.length > ITEM_NAME_MAX_LENGTH) {
                throw new Error('Invalid name length');
            }
            return value;
        }

        function setType(value) {
            var isValid = itemTypes.some(function (item) {
                return item === value;
            });
            if (!isValid) {
                throw new Error('Invalid item type');
            }
            return value;
        }
        
        function setPrice(value) {
            if(!isFloat(value)){
                throw new Error('Invalid price');
            }
            return value;
        }

        return Item;
    } ());
    return Item;
})