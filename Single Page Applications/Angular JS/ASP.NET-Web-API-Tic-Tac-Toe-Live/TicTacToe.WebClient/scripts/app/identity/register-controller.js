(function (undefined) {

    'use strict';

    function RegisterController($scope, auth, $location, notifier) {

        $scope.register = function register(user, registerForm) {
            if (registerForm.$valid) {
                auth.register(user)
                .then(function () {
                    notifier.success('Register success');
                    $location.path('/identity/login');
                },
                function (err) {
                    notifier.error(err.Message);
                })
                
            }
        }
    }

    angular.module('tic-tac-toe.controllers')
        .controller('RegisterController',['$scope', 'auth', '$location', 'notifier', RegisterController]);
})();