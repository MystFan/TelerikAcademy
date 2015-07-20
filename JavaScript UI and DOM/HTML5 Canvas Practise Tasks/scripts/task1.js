// Task 1
// 
// Optional, no points, no deadline Draw the following using canvas:

var canvas = document.getElementById('the-canvas');
var ctx = canvas.getContext("2d");
ctx.lineWidth = '3';


//cilinder
ctx.beginPath();
ctx.moveTo(100, 90);
ctx.lineTo(100, 180);
ctx.quadraticCurveTo(150, 195, 200, 180);
ctx.lineTo(200, 90);
ctx.fillStyle = '#396693';
ctx.fill();


ctx.save();
ctx.scale(1, 0.3);
ctx.arc(150, 300, 50, 2 * Math.PI, false);
ctx.fillStyle = '#396693';
ctx.fill();
ctx.stroke();
ctx.restore();

ctx.beginPath();
ctx.fillStyle = '#396693';
ctx.strokeStyle = '#000';
ctx.moveTo(100, 180);
ctx.bezierCurveTo(-120, 220, 400, 220, 200, 180);
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.fillStyle = '#396693';
ctx.strokeStyle = '#000';
ctx.moveTo(100, 180);
ctx.quadraticCurveTo(150, 210, 200, 180);
ctx.stroke();

//head
function drawArcPath(x, y, r, from, to, isCounterClockwise) {
    ctx.beginPath();
    ctx.arc(x, y, r, from, to, isCounterClockwise);
    ctx.fillStyle = '#90CAD7';
    ctx.strokeStyle = '#1F535F';
    ctx.fill();
    ctx.stroke();
};
drawArcPath(150, 274, 80, 1.7 * Math.PI, 1.3 * Math.PI, false);

//face
ctx.save();
ctx.beginPath();
ctx.scale(1, 0.4);
ctx.arc(100, 650, 20, 2 * Math.PI, false);
ctx.stroke();
ctx.beginPath();
ctx.arc(160, 650, 20,  2 * Math.PI, false);
ctx.stroke();
ctx.restore();

ctx.save();
ctx.beginPath();
ctx.scale(0.7, 1);
ctx.fillStyle = '#1F535F';
ctx.arc(130, 260, 5, 2 * Math.PI, false);
ctx.stroke();
ctx.fill();
ctx.beginPath();
ctx.arc(215, 260, 5, 2 * Math.PI, false);
ctx.stroke();
ctx.fill();
ctx.restore();

ctx.beginPath();
ctx.moveTo(130, 255);
ctx.lineTo(110, 300);
ctx.lineTo(130, 300);
ctx.stroke();

ctx.save();
ctx.translate(30, 180);
ctx.rotate(Math.PI / 15);
ctx.scale(1, 0.4);
ctx.beginPath();
ctx.arc(130, 300, 30, 2 * Math.PI, false);
ctx.stroke();
ctx.restore();

//bicycle

ctx.beginPath();
ctx.arc(200, 650, 80, 0, 2 * Math.PI, false);
ctx.fillStyle = '#90CAD7';
ctx.fill();
ctx.stroke();

ctx.beginPath();
ctx.fillStyle = '#90CAD7';
ctx.strokeStyle = '#388194';
ctx.arc(550, 650, 80, 0, 2 * Math.PI, false);
ctx.stroke();
ctx.fill();
ctx.beginPath();
ctx.moveTo(550, 650);
ctx.lineTo(510, 480);
ctx.lineTo(550, 420);
ctx.moveTo(510, 480);
ctx.lineTo(440, 490);
ctx.moveTo(520, 530);
ctx.lineTo(380, 650);
ctx.lineTo(200, 650);
ctx.lineTo(320, 530);
ctx.lineTo(520, 530);
ctx.moveTo(380, 650);
ctx.lineTo(300, 490);
ctx.moveTo(270, 490);
ctx.lineTo(330, 490);
ctx.stroke();

ctx.beginPath();
ctx.arc(377, 650, 30, 0, 2 * Math.PI, false);
ctx.stroke();
ctx.moveTo(355, 630);
ctx.lineTo(340, 610);
ctx.moveTo(395, 675);
ctx.lineTo(410, 695);
ctx.stroke();

//house
ctx.beginPath();
ctx.moveTo(600, 150);
ctx.fillStyle = 'rgb(151,91,91)';
ctx.strokeStyle = '#000';
ctx.fillRect(600, 150, 350, 300);
ctx.strokeRect(600, 150, 350, 300);
ctx.stroke();

//roof
ctx.beginPath();
ctx.moveTo(775, 50);
ctx.lineTo(603, 148);
ctx.lineTo(947, 148);
ctx.closePath();
ctx.stroke();
ctx.fill();

//windows
ctx.beginPath();
ctx.fillStyle = '#000';
ctx.fillRect(630, 180, 130, 70);
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.fillRect(790, 180, 130, 70);
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.fillRect(790, 270, 130, 70);
ctx.stroke();
ctx.fill();

ctx.beginPath();
ctx.strokeStyle = 'rgb(151,91,91)';
ctx.moveTo(695, 170);
ctx.lineTo(695, 350);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(630, 215);
ctx.lineTo(760, 215);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(855, 180);
ctx.lineTo(855, 250);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(790, 215);
ctx.lineTo(920, 215);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(855, 270);
ctx.lineTo(855, 340);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(790, 305);
ctx.lineTo(920, 305);
ctx.stroke();

//chimny
ctx.beginPath();
ctx.strokeStyle = '#000';
ctx.fillStyle = 'rgb(151,91,91)';
ctx.moveTo(840, 120);
ctx.lineTo(840, 60);
ctx.lineTo(870, 60);
ctx.lineTo(870, 120);
ctx.stroke();
ctx.fill();


ctx.save();
ctx.beginPath();
ctx.scale(1, 0.3);
ctx.arc(855, 200,15, 0, 2 * Math.PI, false);
ctx.stroke();
ctx.fill();
ctx.restore();

//house door
ctx.beginPath();
ctx.moveTo(630, 450);
ctx.lineTo(630, 350);
ctx.quadraticCurveTo(680, 310, 730, 350);
ctx.lineTo(730, 450);
ctx.stroke();

ctx.beginPath();
ctx.moveTo(680, 330);
ctx.lineTo(680, 450);
ctx.stroke();

ctx.beginPath();
ctx.arc(665, 410, 5, 0, 2 * Math.PI, false);
ctx.stroke();

ctx.beginPath();
ctx.arc(695, 410, 5, 0, 2 * Math.PI, false);
ctx.stroke();
