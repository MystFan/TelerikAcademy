(function () {
    'use strict';

    function RegisterController($scope, $location, auth, notifier) {
        $scope.signup = function (user) {
            auth.signup(user).then(function () {
                notifier.success('Registration successful!');
                $location.path('/');
            })
        }
    }

    angular.module('tripExchange.controllers')
        .controller('RegisterController', ['$scope', '$location', 'auth', 'notifier', RegisterController]);
} ());