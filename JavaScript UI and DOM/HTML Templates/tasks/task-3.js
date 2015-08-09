/* global Handlebars, $ */

function solve(){
  return function(){
    $.fn.listview = function(data){
        var templateID = $(this.selector).attr('data-template');
        var template = $('#' + templateID).html();
        var collectionName = 'items';
        template = '{{#each ' + collectionName + '}}' + template + '{{/each}}';
        var func = handlebars.compile(template);
        var result = func({ 'items' : data });
        $(this.selector).html(result);
    };
  };
}

module.exports = solve;