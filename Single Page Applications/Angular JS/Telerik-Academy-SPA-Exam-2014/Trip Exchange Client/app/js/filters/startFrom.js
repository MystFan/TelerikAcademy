(function () {
    'use strict';

    function startFrom() {
        return function (input, start) {
            if (input) {
                start = +start; //parse to int
                return input.slice(start);
            }
        }
    }

    angular.module('tripExchange.controllers')
        .filter('startFrom', [startFrom])
})();