/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {

    return function (element, contents) {
        var index, item, len, container, dFrag,
            div = document.createElement('div');

        if(element === undefined || contents === undefined){
            throw new Error('Missing parameter');
        }
        if (typeof (element) !== 'string' && !(element instanceof HTMLElement)) {
            throw new Error('First parameter must be string id or HTMLELement');
        }
        
        if(typeof element === 'string'){
            container = document.getElementById(element);
            if(container === null){
                throw new Error('Can not find element with provide id');
            }
        }
        else if(element instanceof HTMLElement){
            container = element;
        }
        
        var isValidContents = contents.every(function(item){
            return (typeof item === 'string') || (typeof item === 'number');
        });
        
        if(!isValidContents){
            throw new Error('Invalid element content');
        }
        
        while (container.firstChild) {
            container.removeChild(container.firstChild);
        }

        dFrag = document.createDocumentFragment();
        for (index = 0, len = contents.length; index < len; index += 1) {
            var node = div.cloneNode(true);
            node.innerHTML = contents[index];
            dFrag.appendChild(node);
        }
        container.appendChild(dFrag);
    };
};