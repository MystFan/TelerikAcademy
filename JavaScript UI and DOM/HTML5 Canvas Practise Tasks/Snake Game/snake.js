/*
Optional, no points, no deadline

Create the famous game "Snake"

    The snake is a sequence of rectangles/ellipses
    The snake can move left, right, up or down
    The snake dies if it reaches any of the edges or when it tries to eat itself
    A food should be generated
        When the snake eats the food, it grows and new food is generated at random position
    Implement a high-score board, kept in localStorage

 */

(function(){
    var pause, gameOver, points, directionUp, directionDown, directionLeft, directionRight, food,
    foodImages = ['images/apple.png','images/banana.png','images/lemon.png','images/orange.png','images/pear.png','images/strawberry.png'],
    img,
    FOOD_LIVE_TIME = 10000,
    canvas = document.getElementById('snake-terrain'),
    POINTS_X = canvas.width - 100,
    POINTS_Y = 20,
    context = canvas.getContext('2d'),
    snake = {
        snakeParts: [],
        color: '#19FF19'
    };

    function drawTerrain(ctx){
        ctx.fillStyle = '#ccc';
        ctx.fillRect(0, 0, canvas.width, canvas.height);
        ctx.fillStyle = '#000';
        ctx.font = "18px verdana";
        ctx.fillText('Points: ' + points, POINTS_X, POINTS_Y);
    }

    function init(ctx){
        points = 0;
        if(localStorage.getItem('player')){
            points = localStorage.getItem('player') | 0;
        }

        img = new Image();
        removeMessage();
        food = generateFood();
        drawTerrain(ctx);
        snake.snakeParts = [
            new Part(210,210),
            new Part(180, 210),
            new Part(150, 210)
        ];
        directionRight = true;
        directionDown = false;
        directionLeft = false;
        directionUp = false;
        pause = false;
        gameOver = false;
        drawSnake(ctx);
    }

    function Part(x, y){
        this.x = x;
        this.y = y;
    }

    function drawSnake(ctx){
        for (var i = 0, len = snake.snakeParts.length; i < len; i += 1) {
            ctx.fillStyle = 'black';
            ctx.fillRect(snake.snakeParts[i].x, snake.snakeParts[i].y, 30, 30);
            ctx.fillStyle = snake.color;
            ctx.fillRect(snake.snakeParts[i].x + 5, snake.snakeParts[i].y + 5, 20, 20);
        }
    }

    function printMessage(message){
        var canvas = document.getElementById('snake-terrain');
        var div = document.createElement('div');
        div.id = 'message-box';
        div.style.position = 'absolute';
        div.style.top = parseInt(canvas.height / 2) + 'px';
        div.style.left = parseInt(canvas.width / 2) + 'px';
        div.innerHTML = message;
        document.body.appendChild(div);
    }

    function removeMessage(){
        var msgBox = document.getElementById('message-box');
        if(msgBox){
            document.body.removeChild(msgBox);
        }
    }

    function getRandomInt(min, max) {
        return Math.floor(Math.random() * (max - min + 1)) + min;
    }

    function generateFood(){
        var x = Math.round(getRandomInt(0, canvas.width) / 30) * 30;
        var y = Math.round(getRandomInt(0, canvas.height) / 30) * 30;
        var newFood = new Part(x, y);
        var index = getRandomInt(0,5);
        newFood.img = foodImages[index];
        return newFood;
    }

    function drawFood(ctx, food, imgFood){
        imgFood.src = food.img;
        ctx.drawImage(imgFood, food.x, food.y, 30, 30);
    }

    function snakeCollision(snakeParts){
        /*var hasCollision = false;
        var snakeBody = snakeParts.slice(1);
        snakeBody.forEach(function (part) {
            if(directionDown && snakeParts[0].x === part.x && snakeParts[0].y + 30 === part.y){
                hasCollision = true;
            }
            else if(directionUp && snakeParts[0].x === part.x && snakeParts[0].y - 30 === part.y){
                hasCollision = true;
            }
            else if(directionRight && snakeParts[0].x - 30 === part.x && snakeParts[0].y !== part.y){
                hasCollision = true;
            }
            else if(directionLeft && snakeParts[0].x === part.x + 30 && snakeParts[0].y !== part.y){
                hasCollision = true;
            }
        });
        return hasCollision;*/
    }

    init(context);

    setInterval(function(){
        food = generateFood();
    }, FOOD_LIVE_TIME);

    setInterval(function(){
        context.clearRect ( 0 , 0 , canvas.width, canvas.height );
        drawTerrain(context);


        if(!pause){
            var head_x = snake.snakeParts[0].x;
            var head_y = snake.snakeParts[0].y;

            if(directionRight) head_x+=30;
            else if(directionLeft) head_x-=30;
            else if(directionUp) head_y-=30;
            else if(directionDown) head_y+=30;

            var tail = snake.snakeParts.pop();
            tail.x = head_x;
            tail.y = head_y;
            snake.snakeParts.unshift(tail);


            if(snake.snakeParts[0].x === 0){
                gameOver = true;
                pause = true;
                printMessage('Game over');
            }
            if(snakeCollision(snake.snakeParts)){
                gameOver = true;
                pause = true;
                printMessage('Game over');
            }

            drawFood(context, food, img);

            if(food.x === snake.snakeParts[0].x && food.y === snake.snakeParts[0].y){
                var tailX = snake.snakeParts[snake.snakeParts.length - 1].x;
                var tailY = snake.snakeParts[snake.snakeParts.length - 1].y;
                snake.snakeParts.push(new Part(tailX - 30, tailY));
                food.img = '';
                points += 1;
                localStorage.setItem('player',points);
            }
        }else{

        }


        drawSnake(context);

    },700);

    window.addEventListener('keydown',
        function doKeyDown(evt){
            switch (evt.keyCode) {
                case 13:
                    if(gameOver){
                        gameOver = false;
                        pause = false;
                        init(context);
                    }
                    else{
                        gameOver = true;
                    }
                    break;
                case 32:/* Space was pressed */
                    if(!gameOver){
                        pause = pause ? false : true;
                        if(!pause){
                            removeMessage();
                        }
                        else{
                            printMessage('pouse');
                        }
                    }

                    break;
                case 38:  /* Up arrow was pressed */
                    if(!gameOver && !directionDown)
                        directionUp = true; directionLeft = false; directionRight = false; pouse = false;
                   // direction = 'up';
                    break;
                case 40:  /* Down arrow was pressed */
                    if(!gameOver && !directionUp)
                    directionDown  = true; directionLeft = false; directionRight = false; pouse = false;
                    //direction = 'down';
                    break;
                case 37:  /* Left arrow was pressed */
                    if(!gameOver && !directionRight)
                    directionLeft = true; directionUp = false; directionDown = false; pouse = false;
                    //direction = 'left';
                    break;
                case 39:  /* Right arrow was pressed */
                    if(!gameOver && !directionLeft)
                    directionRight = true; directionUp = false; directionDown = false; pouse = false;
                    //direction = 'right';
                    break;
            }
        }
    );
}());
