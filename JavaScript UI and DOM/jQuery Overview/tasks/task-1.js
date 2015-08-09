/* globals $ */

/* 

Create a function that takes a selector and COUNT, then generates inside a UL with COUNT LIs:   
  * The UL must have a class `items-list`
  * Each of the LIs must:
    * have a class `list-item`
    * content "List item #INDEX"
      * The indices are zero-based
  * If the provided selector does not selects anything, do nothing
  * Throws if
    * COUNT is a `Number`, but is less than 1
    * COUNT is **missing**, or **not convertible** to `Number`
      * _Example:_
        * Valid COUNT values:
          * 1, 2, 3, '1', '4', '1123'
        * Invalid COUNT values:
          * '123px' 'John', {}, [] 
*/

function solve() {
  return function (selector, count) {
      var $list, $container, $item, index, COUNT_MIN_VALUE = 1;
       if(arguments.length === 1){
           throw new Error('Parameter elements count missing');
       }
       if(arguments.length === 0){
           throw new Error('Function parameters missing');
       }
       if(selector === undefined){
           throw new Error('Parameter selector is undefined');
       }
       if(count === undefined){
           throw new Error('Parameter count is undefined');
       }
       if(typeof selector !== 'string'){
           throw new Error('Parameter selector must be type: String');
       }
       if(isNaN(+count)){
           throw new Error('Parameter elements count must be type: Number');
       }
       if(count < COUNT_MIN_VALUE){
           throw new Error('Parameter elements count must be greater than ' + COUNT_MIN_VALUE);
       }
       
       $container = $(selector);
       $list = $('<ul/>').addClass('items-list');
       for (index = 0; index < count; index+=1) {
           $item = $('<li/>')
                        .addClass('list-item')
                        .html('List item #' + index);
           $list.append($item);
       }
       
       $container.append($list);
  };
};

module.exports = solve;