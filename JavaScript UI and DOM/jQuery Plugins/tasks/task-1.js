///<reference path="../typings/jquery/jquery.d.ts"/>

function solve(){
  return function(selector){
     var index, $select = $(selector);
     var itemsCount = $select.children().length;
     $select.hide();
     var $dropdownList = $('<div/>').addClass('dropdown-list');
     $dropdownList.prepend($select);
     var $optionContainer = $('<div/>').addClass('option-container').css({
         'position' : 'absolute',
         'display' : 'none'
     });
     var $current = $('<div/>').addClass('current').attr('data-value', '').attr('data-index', 0);
     
     var $options = $select.find('option');
     for (index = 0; index < itemsCount; index+=1) {
         var $item = $($options.get(index));
         $('<div/>')
                    .addClass('dropdown-item')
                    .attr({
                        'data-value' : $item.attr('value'),
                        'data-index' : index
                    })
                    .html($item.html())
                    .appendTo($optionContainer);
     }
     
     $current.html($($options.get(0)).html());
     $dropdownList.append($current);
     $dropdownList.append($optionContainer);
     
     $dropdownList.on('click', '.current', function(){
         var $this = $(this);
         $optionContainer.css('display', '');
     })
     
     $optionContainer.on('click', '.dropdown-item', function(){
         var $this = $(this);
         $current.attr('data-value', $this.attr('data-value')).html($this.html());
         $optionContainer.css('display', 'none');
         $select.val($this.attr('data-value'));
     })
     $(document.body).append($dropdownList);
     
  };
}

module.exports = solve;