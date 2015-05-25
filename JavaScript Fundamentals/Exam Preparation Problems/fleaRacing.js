var input = ['10', '19', 'angel, 9', 'Boris, 10', 'Georgi, 3', 'Dimitar, 7'];

function solve(params) {
    var numberOfJumps, trackLength, fleas, flea, splitFlea, isFinish, i, p, j;

    numberOfJumps = params[0] - 0;
    trackLength = (params[1] - 0) - 1;
    fleas = [];
    isFinish = false;
    for (i = 2; i < params.length; i++) {
        splitFlea = params[i].split(', ');
        flea = {};
        flea.name = splitFlea[0];
        flea.jumpDistance = splitFlea[1] - 0;
        flea.position = 0;
        flea.winner = false;
        fleas.push(flea);
    }

    for (p = 0; p < numberOfJumps; p++) {
        for (j = 0; j < fleas.length; j++) {
            fleas[j].position += fleas[j].jumpDistance;

            if (fleas[j].position >= trackLength) {
                if (fleas[j].position > trackLength) {
                    fleas[j].position = trackLength;
                }
                isFinish = true;
                break;
            }
        }
        if (isFinish) {
            break;
        }
    }

    function isEqualPositions (array) {

        for (var i = 1; i < array.length; i++) {
            if (array[i].position !== array[0].position)
                return false;
        }

        return true;
    }
    function charRepeat(symbol, length) {
        var str = '';
        for (var i = 0; i < length; i++) {
            str += symbol;
        }
        return str;
    }
    function printResult(arr) {
        var i, j, winnerPos, winner, trackLine = '';

        console.log(charRepeat('#', trackLength + 1));
        console.log(charRepeat('#', trackLength + 1));
        for (j = 0; j < arr.length; j++) {
            for (i = 0; i <= trackLength; i++) {
                if (i === arr[j].position) {
                    trackLine += arr[j].name[0].toUpperCase();
                }
                else {
                    trackLine += '.';
                }
            }
            console.log(trackLine);
            trackLine = '';
        }
        console.log(charRepeat('#', trackLength + 1));
        console.log(charRepeat('#', trackLength + 1));

        winnerPos = -1;
        winner;
        if (isEqualPositions(arr)) {
            winner = arr[arr.length - 1];   //not always be last ,Posible errors
        }
        else {
            for (i = 0; i < arr.length; i++) {
                if (arr[i].position > winnerPos) {
                    winnerPos = arr[i].position;
                    winner = arr[i];
                }
            }
        }
        console.log('Winner: ' + winner.name);
    }
    printResult(fleas);
}

solve(input);