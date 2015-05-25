/**
 * Created by User on 13.5.2015 ã..
 */
//100 points
var test1 = [
    'Sirius 3 7',
    'Alpha-Centauri 7 5',
    'Gamma-Cygni 10 10',
    '8 1',
    '6'
];

var test2 = [
    'Terra-Nova 16 2',
    'Perseus 2.6 4.8',
    'Virgo 1.6 7',
    '2 5',
    '4'
];

function solve(params){
    var galaxy, galaxies, splitGalaxy, normandy, splitCoordinates, numberOfTurns, inGalaxy, i, j;
    galaxies = [];
    for (var i = 0; i < 3; i++) {
        splitGalaxy = params[i].split(' ');
        galaxy = {};
        galaxy.name = splitGalaxy[0];
        galaxy.x = splitGalaxy[1] - 0;
        galaxy.y = splitGalaxy[2] - 0;
        galaxies.push(galaxy);
    }

    normandy = {};
    splitCoordinates = params[3].split(' ');
    normandy.x = splitCoordinates[0] - 0;
    normandy.y = splitCoordinates[1] - 0;
    numberOfTurns = params[4] - 0;
    inGalaxy = false;
    for (i = 0; i < numberOfTurns + 1; i++) {

        for (j = 0; j < galaxies.length; j++) {
            if((galaxies[j].x === normandy.x && galaxies[j].y === normandy.y) || ((galaxies[j].x - 1 <= normandy.x && galaxies[j].x + 1 >= normandy.x)
            && (galaxies[j].y - 1 <= normandy.y && galaxies[j].y + 1 >= normandy.y))){
                console.log(galaxies[j].name.toLowerCase());
                inGalaxy = true;
                break;
            }
        }

        if(!inGalaxy){
            console.log('space');
        }
        inGalaxy = false;
        normandy.y++;

    }
}


solve(test1);
solve(test2);
