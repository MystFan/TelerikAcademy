(function () {

    'use strict';

    function LoginController($scope, $location, auth, notifier) {

        $scope.login= function login(user, loginForm){
            if (loginForm.$valid) {
                auth.login(user)
                .then(function () {
                    notifier.success('Login success!');
                    $location.path('/');
                },
                function (err) {
                    notifier.error(err.Message);
                });
            }
        }
    }

    angular.module('tic-tac-toe.controllers')
    .controller('LoginController', ['$scope', '$location', 'auth', 'notifier', LoginController]);
})();