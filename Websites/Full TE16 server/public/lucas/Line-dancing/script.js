var ctx;
var totalHeight;
var totalWidth;
var scrMid;
var gravity;

var player1;
var player2;

$(document).ready(function(){
    gravity = 30;

    totalHeight = $("#myCanvas")[0].height;
    totalWidth = $("#myCanvas")[0].width;

    scrMid = totalHeight * 9 / 10;

    player1 = new Player(totalWidth / 3, 1, "blue");
    player2 = new Player(totalWidth * 2 / 3, -1, "green");

    ctx = $("#myCanvas")[0].getContext("2d");

    document.addEventListener("keydown", keyDownHandler, false);
    document.addEventListener("keyup", keyUpHandler, false);
    document.addEventListener("keydown", function (e) {
        // space, page up, page down and arrow keys:
        if ([32, 33, 34, 37, 38, 39, 40].indexOf(e.keyCode) > -1) {
            e.preventDefault();
        }
    }, false);

    $("#gravity").val(gravity);

    $("#gravity")[0].addEventListener("input", function(e){
        gravity = $("#gravity").val();
    }, false);
    
    scriptUpdate();
})

function scriptUpdate() {
    ctx.clearRect(0, 0, totalWidth, totalHeight);
    line(totalWidth/7, scrMid, totalWidth*6/7, scrMid, 10, "black");
    
    player1.Draw();
    player2.Draw();
    
    KeyboardInput();
    
    player2.CheckCollision(player1);
    player1.CheckCollision(player2);

    requestAnimationFrame(scriptUpdate);
}

var keyboardPress = {
    w: false,
    a: false,
    d : false,
    space : false,

    up : false,
    left : false,
    right : false,
    enter : false,

    t : false
};

var Player = function (x, dir, color) {
    this.x = x,
    this.y = 0,
    this.dir = dir, //1 = right, -1 = left
    this.len = totalHeight / 10,
    this.armOut = 0,
    this.armY = -7,
    this.throwback = 0,
    this.flyDir = 0,
    this.color = color,
    this.yVel = 0,
    this.bouncing = false,
    this.jumping = false,
    this.charging = false,
    this.jumpCharge = 0,
    this.hasCharged = false,
    this.damage = 0,
    this.armRetracting = false
}

Player.prototype.Draw = function () {

    var yThing = scrMid - this.len * 4 / 3;
    var headX = this.x - 20 * this.dir;
    var headY = yThing + this.y - 40;

    //Take punch knockback
    if (this.throwback > 0) {
        this.x += this.throwback * -this.dir * this.damage;
        this.throwback -= 2;
    }

    //Take border knockback
    if (this.flyDir != 0) {
        this.x += this.flyDir;
        this.y -= 15;
        this.jumping = true;
    }

    //Falling/jumping


    if (this.charging == true && this.hasCharged == false) {
        this.jumping = true;
        this.yVel += this.jumpCharge;
        this.jumpCharge = 0;
        this.charging = false;
        this.hasCharged = false;
    }
    if (this.charging == true) {
        headY += 20;
        this.hasCharged = false;
    }

    if ((this.y > 0 || this.y - this.yVel > 0) && this.jumping == true) {
        this.y = 0;
        this.jumping = false;
        this.yVel = 0;
    }
    else if (this.y <= 0 && this.jumping == true) {
        this.y -= this.yVel;
        this.yVel -= gravity / 50;

    }


    //Arm
    line(this.x, scrMid + this.y - this.len + this.armY,
         this.x + this.armOut * this.dir,
         scrMid + this.y - this.len + this.armY, 10, this.color);
    //Hand
    var handLength = 15;
    if (this.armOut < handLength)
        handLength = this.armOut;
    rectangle(this.x + (this.armOut - handLength) * this.dir,
              scrMid + this.y - this.len + this.armY - 10, handLength * this.dir,
              20, "orange");
    //Fingers
    for (i = 0; i < 2; i++) {
        line(this.x + (this.armOut - 1) * this.dir,
                scrMid + this.y - this.len + this.armY - 3 + 6 * i,
                this.x + (this.armOut - handLength / 2) * this.dir,
                scrMid + this.y - this.len + this.armY - 3 + 6 * i, 3, this.color);
    }
    //Body
    line(this.x, scrMid + this.y - this.len / 3, this.x,
         yThing + this.y, 10, this.color);
    //Head
    rectangle(headX, headY, 40 * this.dir, 40, this.color);
    //Eye
    rectangle(headX + 30 * this.dir,
              headY + 10, 10 * this.dir, 10, "white");

    //Damage bar
    var barX = totalWidth / 2 - totalWidth * 1 / 3 * this.dir
    rectangle(barX, scrMid + 35,
              this.damage * 30 * this.dir, 20, "red");
    rectangle(barX, scrMid + 20, 100 * this.dir, 10, this.color);
}

Player.prototype.Move = function (dist) {
    if (this.charging == true)
        dist /= 2;
    if (this.bouncing == false)
        this.x += dist;
}

Player.prototype.Jump = function (charge) {
    if (this.jumping == false && this.jumpCharge < 19) {
        this.charging = true;
        this.hasCharged = true;
        this.jumpCharge += charge;
    }
}

Player.prototype.MoveArm = function (push) {
    if(this.armOut > 60){
        this.armRetracting = true;
        this.armOut -= 3;
    }
    else {
        if (push && this.charging == false && !this.armRetracting)
            this.armOut += 4;
        else if (this.armOut < 0){
            this.armOut = 0;
            this.armRetracting = false;
        }
        else if (this.armOut > 0)
            this.armOut -= 3;
    }

}

Player.prototype.CheckCollision = function (object) {

    //Check if hit
    var thisTop = scrMid + this.y - this.len * 4 / 3 - 40;
    var thisBottom = scrMid + this.y - this.len / 3;
    var objectArm = scrMid + object.y - object.len + object.armY;

    var dist = object.x + object.armOut * object.dir - this.x;

    if ((dist < 5 && dist > -5) && object.armOut != 0 &&
        objectArm > thisTop && objectArm < thisBottom) {
        this.throwback = totalWidth / 45;
        this.damage += this.throwback / 100;
    }

    //Check if over the edge
    if (this.x < totalWidth / 7) {
        this.bouncing = true;
        this.flyDir = totalWidth * gravity / 1800;
        this.yVel = 0;
    }
    else if (this.x > totalWidth * 6 / 7) {
        this.bouncing = true;
        this.flyDir = -totalWidth * gravity / 1800;
        this.yVel = 0;
    }

    //Check if on other side of the other player
    if (this.x > player1.x || this.x > player2.x) {
        this.dir = -1;
    }
    else if (this.x < player1.x || this.x < player2.x) {
        this.dir = 1;
    }

    //Check if fallen upon
    if (object.jumping == true && object.y > this.y - (this.len + 40)  && object.y > this.y -20
        && object.yVel < 0 && (object.x < this.x + 70 && object.x > this.x -70)) {

        this.throwback = totalWidth / 45 * object.yVel * -1 / 20;
        this.damage += this.throwback / 100;
    }
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

function KeyboardInput(){
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