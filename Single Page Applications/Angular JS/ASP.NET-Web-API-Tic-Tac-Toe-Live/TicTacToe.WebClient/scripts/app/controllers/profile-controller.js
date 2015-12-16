(function () {
    'use strict';

    function ProfileController($scope, $location, $rootScope, games, notifier) {
        
        $scope.createGame = function createGame() {
            games.create()
            .then(function (res) {
                notifier.success('Create game success!');
                $location.path('/game/details/' + res);
            })
        }

        games.all()
            .then(function (games) {
                var allGames = games.map(function (game) {
                    if ($rootScope.shareCurrentUser.Email === game.FirstPlayerName) {
                        game.yourSymbol = 'X';
                    }
                    else{
                        game.yourSymbol = 'O';
                    }

                    return game;
                });

                $scope.liveGames = allGames.filter(function (game) {
                    return game.State === 'TurnO' || game.State === 'TurnX' || game.State === 'WaitingForSecondPlayer';
                });

                $scope.finishedGames = allGames.filter(function (game) {
                    return !(game.State === 'TurnO' || game.State === 'TurnX' || game.State === 'WaitingForSecondPlayer');
                });
            })

        $scope.joinGame = function joinGame() {
            games.join()
                .then(function (res) {
                    notifier.success('Join success!');
                    $location.path('/game/details/' + res);
                },
                function (err) {
                    notifier.error('Not available games!');
                });
        }
    }

    angular.module('tic-tac-toe.controllers')
    .controller('ProfileController', ['$scope', '$location', '$rootScope', 'games', 'notifier', ProfileController])
})();