(function () {

    function rect(x, y, w, h) {
        return {
            x: x,
            y: y,
            width: w,
            height: h
        };
    }

    var score = $.connection.saveResult;

    score.client.getPlayerScore = function () {
        return playerScore;
    };

    score.client.setMessage = function setMessage(msg) {
        message = msg;
    };

    $.connection.hub.start();

    var field = document.getElementById('pong-field'),
        ctx = field.getContext('2d');

    var paddle = rect(0, field.height / 2 - 25, 10, 70),
        ball = rect(field.width / 2, field.height / 2, 15, 15),
        keys = { W: 87, S: 83 }, keyboard = [],
        paddleSpeed = 2,
        playing = false,
        playerScore = 0,
        computerScore = 0,
        message = '';

    ball.dx = 2;
    ball.dy = 2;

    window.onkeydown = function (ev) {
        keyboard[ev.which] = true;
    }

    window.onkeyup = function (ev) {
        keyboard[ev.which] = false;
    }

    function render() {
        ctx.fillStyle = 'black';
        ctx.fillRect(0, 0, field.width, field.height);
        ctx.fillStyle = 'white';

        ctx.fillRect(paddle.x, paddle.y, paddle.width, paddle.height);
        ctx.fillRect(ball.x, ball.y, ball.width, ball.height);

        ctx.font = '48px Consolas';
        ctx.fillText(computerScore, field.width - 80, 50)
        ctx.fillText(playerScore, 50, 50)
        ctx.font = '32px Consolas';
        ctx.fillText(message, 150, 50)

        requestAnimationFrame(render);
    }

    function update() {
        if (!playing) {
            return;
        }

        if (keyboard[keys.W] && paddle.y >= 0) {
            paddle.y -= paddleSpeed;
        }
        else if (keyboard[keys.S] && paddle.y + paddle.height <= field.height) {
            paddle.y += paddleSpeed;
        }

        ball.x += ball.dx;
        ball.y += ball.dy;


        if (ball.y <= 0 || ball.y + ball.height >= field.height) {
            ball.dy = -ball.dy;
        }
        if (ball.x <= 0 || ball.x + ball.width >= field.width) {
            ball.dx = -ball.dx;
        }

        if (ball.x <= paddle.x + paddle.width
                && ball.y <= paddle.y + paddle.height
                && ball.y + ball.height >= paddle.y) {
            ball.dx = -ball.dx;
            playerScore += 1;
            score.server.getPlayerScore(playerScore);
            score.server.getPlayerMessage();
        }

        if (ball.x + 2 < paddle.x + paddle.width) {
            playing = false;
            computerScore += 2;
            setTimeout(reset, 1000);
            score.server.getComputerScore(computerScore);
            score.server.getComputerMessage();
            return;
        }

        setTimeout(update, 10);
    }

    function reset() {
        playing = true;

        ball.x = field.width / 2;
        ball.y = field.height / 2;

        setTimeout(update, 10);
        requestAnimationFrame(render);
    };

    reset();

})();