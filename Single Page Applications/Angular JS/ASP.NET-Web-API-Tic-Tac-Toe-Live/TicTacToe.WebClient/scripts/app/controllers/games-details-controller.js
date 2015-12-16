(function () {
    'use strict';

    function GameDetailsController($scope, $routeParams, games) {

        games.details($routeParams.id)
            .then(function (game) {
                var gameViewModel = getGameModel(game);
                $scope.gameViewModel = gameViewModel;
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

    angular.module('tic-tac-toe.controllers')
        .controller('GameDetailsController', ['$scope', '$routeParams', 'games', GameDetailsController]);
})();