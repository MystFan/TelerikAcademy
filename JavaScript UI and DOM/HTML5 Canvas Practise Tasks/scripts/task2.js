// Task 2
// 
// Optional, no points, no deadline
// 
// `Draw a circle that flies inside a box
// 
//     When it reaches an edge, it should bounce that edge
var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext("2d");

ctx.strokeStyle = '#000';
ctx.lineWidth = '2';

ctx.strokeRect(150, 150, 650, 550);
ctx.stroke();

function drowBall(x, y, r, from, to, clock) {
    ctx.beginPath();
    ctx.arc(x, y, r, from, to, clock);
    ctx.fillStyle = '#009400';
    ctx.fill();
    ctx.stroke();
}

var x = 200,
    y = 200,
    r = 20,
    from = 0,
    to = Math.PI * 2,
    clock = false,
    updateX = 5,
        updateY = 5,
		speed = 3;

var rightSide = 830;
var leftSide = 220;
var upSide = 220;
var downSide = 730;

function moveBall() {
    ctx.clearRect(0, 0, ctx.canvas.width, ctx.canvas.height);
    ctx.strokeRect(180, 180, 650, 550);
    drowBall(x, y, r, from, to, clock);
    
   
    if (x + r >= rightSide) {
        updateX = -speed;
    }
    if (x + r <= leftSide) {
        updateX = speed;
    }

    if (y + r <= upSide) {
        updateY = speed;
    }
    if (y + r >= downSide) {
         updateY = -speed;
    }

    x += updateX;
    y += updateY;
    requestAnimationFrame(moveBall);
}
requestAnimationFrame(moveBall);
