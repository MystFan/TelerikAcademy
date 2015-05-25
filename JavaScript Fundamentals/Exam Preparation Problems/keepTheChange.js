var test1 = [
'120.44',
'happy'
];
var test2 = [
'1230.83',
'drunk'
];
var test3 = [
'716.00',
'bored'
];
function solve(params) {
    var mood, bill, tip;
    mood = params[1];
    bill =  params[0] - 0;
    if (bill < 0) {
        return 0;
    }
    if (mood === 'happy') {
        tip = ((bill / 100) * 10).toFixed(2);
    }
    else if (mood === 'married') {
        tip = ((bill / 100) * 0.05).toFixed(2);
    }
    else if (mood === 'drunk') {
        tip = ((bill / 100) * 15).toFixed(2);
        tip = Math.pow(tip - 0, tip.toString()[0] - 0);
    }
    else {
        tip = ((bill / 100) * 5).toFixed(2);
    }
    return tip;
}
console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));