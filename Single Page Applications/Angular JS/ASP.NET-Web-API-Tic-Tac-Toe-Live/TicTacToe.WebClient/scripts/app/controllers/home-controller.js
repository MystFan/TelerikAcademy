(function () {

    'use strict';
    
    function HomeController($scope) {
        $scope.hi = 'Hi';
    }

    angular.module('tic-tac-toe.controllers')
        .controller('HomeController', ['$scope', HomeController]);
})();