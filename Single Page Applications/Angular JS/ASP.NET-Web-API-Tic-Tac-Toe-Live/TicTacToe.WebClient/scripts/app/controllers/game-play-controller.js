(function () {
    'use strict';

    function GamePlayController($scope, $location, $routeParams, $interval, games, notifier) {

        $scope.gameId = $routeParams.id;

        var stop = $interval(function () {
            games.details($routeParams.id)
                .then(function (res) {
                    $scope.board = updateBoard(res);
                    $scope.currentGame = getGameModel(res);
                })
        }, 3000)

        games.details($routeParams.id)
            .then(function (res) {
                $scope.board = updateBoard(res);
                $scope.currentGame = getGameModel(res);
            })

        $scope.save = function (value) {
            $scope.coordinates = value.split(',');
            $scope.row = $scope.coordinates[0] | 0;
            $scope.col = $scope.coordinates[1] | 0;
            var model = {
                gameId: $scope.gameId,
                row: $scope.row,
                col: $scope.col
            }

            games.play(model)
              .then(function (res) {
                  console.log(res);
              },
              function (err) {
                  notifier.error(err.Message);
              });
        }

        function getGameModel(game) {
            var model = {};

            model.id = game.Id;
            model.board = game.Board;
            model.firstPlayerName = game.FirstPlayerName;
            model.secondPlayerName = game.SecondPlayerName;

            switch (game.State) {
                case 0: model.state = 'Waiting for second player'; break;
                case 1: model.state = 'Turn X'; break;
                case 2: model.state = 'Turn O'; break;
                case 3: model.state = 'Won by X'; break;
                case 4: model.state = 'Won by O'; break;
                case 5: model.state = 'Draw'; break;
            }

            return model;
        }

        function updateBoard(value) {
            var field = value.Board.split('');
            var board = [];
            var index = -1;
            for (var i = 1; i <= 3; i++) {
                for (var j = 1; j <= 3; j++) {
                    index++;
                    board.push({
                        cord: i + ',' + j,
                        symbol: field[index]
                    });
                }
            }

            return board;
        }

        $scope.$on("$destroy", function () {
            $interval.cancel(stop);
        });
    }

    angular.module('tic-tac-toe.controllers')
        .controller('GamePlayController', ['$scope', '$location', '$routeParams', '$interval', 'games', 'notifier', GamePlayController])
})();