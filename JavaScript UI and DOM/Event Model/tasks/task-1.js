/* globals $ */

/* 

Create a function that takes an id or DOM element and:
* If an id is provided, select the element
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided DOM element is non-existant
  * The id is either not a string or does not select any DOM element

*/

function solve() {
    return function (selector) {
        var buttons, contents, index, len;
        if (selector === undefined) {
            throw new Error('Selector is undefined');
        }
        if (typeof selector !== 'string') {
            throw new Error('Parameter selector must be type: String');
        }

        var rootNode = document.getElementById(selector);

        if (!rootNode) {
            throw new Error('Can not select element with id: ' + selector);
        }

        buttons = rootNode.getElementsByClassName('button');
        contents = rootNode.getElementsByClassName('content');

        for (index = 0, len = buttons.length; index < len; index += 1) {
            buttons[index].innerHTML = 'hide';
        }

        rootNode.addEventListener('click', function (ev) {
            var item, currentItem, target = ev.target;
            var targetClass = target.getAttribute('class');
            if (targetClass === 'button') {

                currentItem = target;
                while (true) {
                    currentItem = currentItem.nextElementSibling;
                    if (!currentItem) {
                        break;
                    }
                    if (currentItem.className === 'content') {
                        item = currentItem;
                        break;
                    }
                }

                if (item) {
                    if (item.style.display === 'none') {
                        item.style.display = '';
                        target.innerHTML = 'hide';
                    }
                    else {
                        item.style.display = 'none';
                        target.innerHTML = 'show';
                    }
                }
            }
        })
    };
};

module.exports = solve;