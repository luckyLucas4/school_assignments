var BALL_SPEED = parseInt(prompt("Ball Speed"));
BALL_SPEED = isNaN(BALL_SPEED) ? 10 : BALL_SPEED;
var SPAWN_TIME = parseInt(prompt("Ball Spawn Time, seconds"));
SPAWN_TIME = isNaN(SPAWN_TIME) ? 5 : SPAWN_TIME;

var player = {
    x: 100,
    y: 100,
    size: 15
};
var balls = [];
var enemies = [];
var bSpawnCount = 0;
var eSpawnCount = 0;
var updates = 0;

for (i = 0; i < 10; i++) {
    balls.push({
        x: 30 + random(totalWidth - 60),
        y: 30 + random(totalHeight - 60),
        size: 7 + random(20),
        color: mixColor(random(255), random(255), random(255)),
        alive: true
    });
}



function update() {
    clearScreen();

    //text(10, 10, 10, balls.length, "black");
    //text(10, 25, 10, bSpawnCount, "black");
    //text(10, 40, 10, balls[balls.length-1].y, "black");
    //text(10, 55, 10, totalHeight, "black");
    //text(10, 70, 10, totalWidth, "black");

    /*for(i=0; balls.length > i; i++)
    {
      text(50, 10 + 15*i, 10,/* balls[i].alive + " " + balls[i].x
           + " " + balls[i].y + " " + balls[i].size, "black");
    }
    */

    //+ balls[balls.length-1].y

    //Move player
    if (keyboard.d && player.x < totalWidth)
        player.x += BALL_SPEED;
    if (keyboard.a && player.x > 0)
        player.x -= BALL_SPEED;
    if (keyboard.s && player.y < totalHeight)
        player.y += BALL_SPEED;
    if (keyboard.w && player.y > 0)
        player.y -= BALL_SPEED;

    //Draw player
    circle(player.x, player.y, player.size, "orange");
    rectangle(player.x - player.size / 2.5, player.y - player.size / 3, player.size / 2.5, player.size / 2.5, "black");
    rectangle(player.x + player.size / 2.5, player.y - player.size / 3, player.size / 2.5, player.size / 2.5, "black");
    line(player.x - player.size / 2.5, player.y + player.size / 2, player.x + player.size / 2.5,
         player.y + player.size / 2, player.size / 10, "black");

    //Draw enemies
    for (i = 0; i < enemies.length; i++) {
        if (enemies[i].alive === true) {
            enemies[i].x += enemies[i].dx;
            enemies[i].y += enemies[i].dy;
            circle(enemies[i].x, enemies[i].y, enemies[i].size, "red");
            rectangle(enemies[i].x - enemies[i].size / 2, enemies[i].y - enemies[i].size / 2,
                      enemies[i].size, enemies[i].size, "black");
        }
    }

    //Enemy collision detect
    for (i = 0; i < enemies.length; i++) {
        var dx = player.x - enemies[i].x;
        var dy = player.y - enemies[i].y;

        var dist = sqrt(dx * dx + dy * dy);
        if (dist - (enemies[i].size + player.size) < 0
           && enemies[i].alive === true) {
            if (player.size > enemies[i].size) {
                enemies[i].alive = false;
                player.size += enemies[i].size / 15;
            } else {
                stopUpdate();
            }
        }
    }

    //Draw balls
    for (i = 0; i < balls.length; i++) {
        if (balls[i].alive === true) {
            circle(balls[i].x, balls[i].y, balls[i].size, balls[i].color);
        }
    }

    //Balls collision detect
    for (i = 0; i < balls.length; i++) {
        var dx = player.x - balls[i].x;
        var dy = player.y - balls[i].y;

        var dist = sqrt(dx * dx + dy * dy);
        if (dist - (balls[i].size + player.size) < 0 && balls[i].alive === true) {
            if (player.size > balls[i].size) {
                balls[i].alive = false;
                player.size += balls[i].size / 15;
            }
            else {
                stopUpdate();
            }
        }
    }


    updates++;

    if (updates >= updatesPerSecond) {
        bSpawnCount++;
        eSpawnCount++;
        updates = 0;
    }
    if (bSpawnCount >= SPAWN_TIME) {
        balls.push({
            x: 30 + random(totalWidth - 60),
            y: 30 + random(totalHeight - 60),
            size: player.size + random(20),
            color: mixColor(random(255), random(255), random(255)),
            alive: true
        });
        bSpawnCount = 0;
    }
    if (eSpawnCount >= 1) {
        var side = floor(random(4));
        var eX;
        var eY;
        var eDX;
        var eDY;
        switch (side) {
            case 0:
                eX = 0;
                eY = random(totalHeight);
                eDX = random(7) + totalWidth / 600;
                eDY = 0;
                break;
            case 1:
                eX = random(totalWidth);
                eY = 0;
                eDX = 0;
                eDY = random(7) + 1;
                break;
            case 2:
                eX = totalWidth;
                eY = random(totalHeight);
                eDX = -(random(7) + totalWidth / 600);
                eDY = 0;
                break;
            case 3:
                eX = random(totalWidth);
                eY = totalHeight;
                eDX = 0;
                eDY = -(random(7) + 1);
                break;
            default:
                break;
        }

        enemies.push({
            x: eX, y: eY, dx: eDX, dy: eDY,
            size: player.size - 10 + random(20), alive: true
        });
        eSpawnCount = 0;
    }
}

function init() {
    canvas = document.getElementById("myCanvas");
    ctx = canvas.getContext("2d");

    document.addEventListener("keydown", keyDownHandler, false);
    document.addEventListener("keyup", keyUpHandler, false);

    scriptUpdate();
}

function keyDownHandler(e) {
    switch (e.keyCode) {
        case 87:
            keyboardPress.w = true;
            break;
        case 65:
            keyboardPress.a = true;
            break;
        case 68:
            keyboardPress.d = true;
            break;
        case 32:
            keyboardPress.space = true;
            break;

        case 38:
            keyboardPress.up = true;
            break;
        case 37:
            keyboardPress.left = true;
            break;
        case 39:
            keyboardPress.right = true;
            break;
        case 13:
            keyboardPress.enter = true;
            break;

        case 84:
            keyboardPress.t = true;
            break;

        default:
            break;
    }
}
function keyUpHandler(e) {
    switch (e.keyCode) {
        case 87:
            keyboardPress.w = false;
            break;
        case 65:
            keyboardPress.a = false;
            break;
        case 68:
            keyboardPress.d = false;
            break;
        case 32:
            keyboardPress.space = false;
            break;

        case 38:
            keyboardPress.up = false;
            break;
        case 37:
            keyboardPress.left = false;
            break;
        case 39:
            keyboardPress.right = false;
            break;
        case 13:
            keyboardPress.enter = false;
            break;

        case 84:
            keyboardPress.t = false;
            break;

        default:
            break;
    }
}

function KeyboardInput() {
    if (keyboardPress.d)
        player1.Move(6);
    if (keyboardPress.a)
        player1.Move(-6);
    if (keyboardPress.w)
        player1.Jump(0.5);

    if (keyboardPress.right)
        player2.Move(6);
    if (keyboardPress.left)
        player2.Move(-6);
    if (keyboardPress.up)
        player2.Jump(0.5);

    if (keyboardPress.space)
        player1.MoveArm(true);
    else
        player1.MoveArm(false);

    if (keyboardPress.enter)
        player2.MoveArm(true);
    else
        player2.MoveArm(false);

    if (keyboardPress.t)
        player2.throwback += 100;
}

function update() {
    line(totalWidth / 7, scrMid, totalWidth * 6 / 7, scrMid, 10, "black");

    player1.Draw();
    player2.Draw();

    KeyboardInput();

    player2.CheckCollision(player1);
    player1.CheckCollision(player2);
}

function rectangle(x, y, width, height, color) {
    ctx.fillStyle = color;
    ctx.fillRect(x, y, width, height);
}
function line(x1, y1, x2, y2, width, color) {
    ctx.strokeStyle = color;
    ctx.lineWidth = width;
    ctx.beginPath();
    ctx.moveTo(x1, y1);
    ctx.lineTo(x2, y2);
    ctx.stroke();
}

function scriptUpdate() {
    ctx.canvas.width = window.innerWidth;
    ctx.canvas.height = window.innerHeight;
    ctx.clearRect(0, 0, totalWidth, totalHeight)
    update();
    requestAnimationFrame(scriptUpdate);
}

window.addEventListener("keydown", function (e) {
    // space, page up, page down and arrow keys:
    if ([32, 33, 34, 37, 38, 39, 40].indexOf(e.keyCode) > -1) {
        e.preventDefault();
    }
}, false);

init();