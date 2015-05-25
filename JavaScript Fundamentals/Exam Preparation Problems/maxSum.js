

var test1 = ['8', '1', '6', '-9', '4', '4', '-2', '10', '-1'];
var test2 = [
'9',
'-9',
'-8',
'-8',
'-7',
'-6',
'-5',
'-1',
'-7',
'-6'
];
function solve(params) {
    var N = parseInt(params[0]);
    var answer = 0;
    var seq = [];
    for (var i = 1; i < params.length; i++) {
        seq.push(params[i]);
    }

    var numbers = seq.map(Number);

    var currentSum = 0;
    var currentMax = 0;

    for (var j = 0; j < numbers.length; j++)
    {
        currentSum += numbers[j];

        if (currentMax < currentSum) {
            currentMax = currentSum;
        }
        else if (currentSum < 0) {
            currentSum = 0;
        }
    }
    
    var isAllNegativ = true;
    for (var p = 0; p < numbers.length; p++) {
        if (numbers[p] > 0) {
            isAllNegativ = false;
            break;
        }
    }

    if (isAllNegativ) {
        numbers.sort();
        return numbers[0];
    }
    else {
        return currentMax;
    }
}
console.log(solve(test2));
