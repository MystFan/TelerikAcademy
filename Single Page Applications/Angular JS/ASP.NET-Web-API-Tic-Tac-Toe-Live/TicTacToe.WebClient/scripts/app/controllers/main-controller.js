(function () {
    'use strict';

    function MainController($scope, $location, $rootScope, auth, identity, notifier) {

        waitForLogin();

        $scope.logout = function logout(user) {
            $scope.globalSetCurrentUser = undefined;
            $rootScope.shareCurrentUser = undefined;
            auth.logout();
            waitForLogin();
            notifier.success('Logout success!');
            $location.path('/home');
        }

        function waitForLogin() {
            identity.getUser()
            .then(function (user) {
                $scope.globalSetCurrentUser = user;
                $rootScope.shareCurrentUser = user;
            })
        }
    }

    angular.module('tic-tac-toe.controllers')
        .controller('MainController', ['$scope', '$location', '$rootScope', 'auth', 'identity', 'notifier', MainController]);
})();