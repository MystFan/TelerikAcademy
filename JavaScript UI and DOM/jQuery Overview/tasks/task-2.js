/* globals $ */

/*
Create a function that takes a selector and:
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
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
    return function (selector) {
        var $container, $buttons, $contents;
        if (selector === undefined) {
            throw new Error('Parameter selector is undefined');
        }
        if (typeof selector !== 'string' && !(selector instanceof $)) {
            throw new Error('Parameter selector must be type: String or JQuery object');
        }
        if ((selector instanceof $) && !(typeof selector !== 'string')) {
            throw new Error('Parameter selector must be type: String or JQuery object');
        }
        
        if(selector instanceof $){
            $container = selector;
        }
        else if(typeof selector === 'string'){
            $container = $(selector);
            if($container.length === 0){
                throw new Error('Selector can not');
            }
        }
        
        
        $buttons = $container.find('.button');
        $contents = $container.find('.content');
        
        $buttons.each(function(index, item){
           $(item).html('hide'); 
        });
        
        $container.on('click', function(ev){
            var $target = $(ev.target);
            var $next = $($target.nextAll('.content')).first();
            if($next.css('display') === 'none'){
                $next.css('display','');
                $target.text('hide');
            }
            else{
                $next.css('display', 'none');
                $target.text('show');
            }
        })
    };
};

module.exports = solve;