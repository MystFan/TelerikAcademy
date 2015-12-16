(function () {
    'use strict';

    function getCellValue() {
        return {
            restrict: 'A',
            link: function (scope, element, attrs) {
            }
        }
    }

    angular.module('tic-tac-toe')
        .directive('rowCol', getCellValue);
})();