var ctx;
var upPressed, downPressed;
var shapes;
var countFrames;
var currentShape;
var shapeInput;

$(document).ready(function(){

  ctx = $("#myCanvas")[0].getContext("2d");

  shapes = [];
  countFrames = 0;
  currentShape = -1;
  upPressed = false;
  downPressed = false;

  document.addEventListener("keydown", keyDownHandler, false);
  document.addEventListener("keyup", keyUpHandler, false);
  document.addEventListener("keypress", keyPressHandler, false);

  $("#drawBtn").click(function(){
    upPressed = !upPressed;
    if(upPressed){
      $("#drawBtn").html("<b>Stop drawing!</b>");
    } else{
      $("#drawBtn").html("<b>Start drawing!</b>");
    }
  })

  $("#eraseBtn").click(function(){
    downPressed = !downPressed;
    if(downPressed){
      $("#eraseBtn").html("<b>Stop erasing!</b>");
    } else{
      $("#eraseBtn").html("<b>Start erasing!</b>");
    }
  })

  $("#swlBtn").click(function(){
    if (currentShape > 0) {
      currentShape--;
  }
  })

  $("#swrBtn").click(function(){
    if (currentShape < shapes.length - 1) {
      currentShape++;
    }
  })

  NewShape();
  Draw();

});

function Draw() {
  var x;
  var y;
  var width;
  var stroke;
  
  var subX;
  if( $("#xText").val() == ""){
    subX = 0;
  }
  else {
    subX = $("#xText").val();
  }

  var subY;
  if( $("#yText").val() == ""){
    subY = 0;
  }
  else {
    subY = $("#yText").val();
  }

  var subWidth;
  if( $("#widthText").val() == ""){
    subWidth = 0;
  }
  else {
    subWidth = $("#widthText").val();
  }

  var subStroke;
  if( $("#strokeText").val() == ""){
    subStroke  = 0;
  }
  else {
    subStroke = $("#strokeText").val();
  }

  x = ( shapeInput.x != $("#xField").val() ? $("#xField").val() : subX );
  y = ( shapeInput.y != $("#yField").val() ? $("#yField").val() : subY );
  width = ( shapeInput.width != $("#widthField").val() ? $("#widthField").val() : subWidth );
  stroke = ( shapeInput.stroke != $("#strokeField").val() ? $("#strokeField").val() : subStroke );

  $("#xField").val(x);
  if(x != 0){
    $("#xText").val(x);
  }
  shapeInput.x = x;

  $("#yField").val(y);
  if(y != 0){
    $("#yText").val(y);
  }
  shapeInput.y = y;

  $("#widthField").val(width);
  if(width != 0){
    $("#widthText").val(width);
  }
  shapeInput.width = width;

  $("#strokeField").val(stroke);
  if(stroke != 0){
    $("#strokeText").val(stroke);
  }
  shapeInput.stroke = stroke;
  
  KeyHandler();

  countFrames++;
  setTimeout(Draw, 50);
}

function KeyHandler() {
  if (upPressed) {
  shapes[currentShape].DrawLine();
  shapes[currentShape].MovePoints(10);
} else if (downPressed) {
  shapes[currentShape].Erase();
} else if (upPressed) {
  if (currentShape < shapes.length - 1) {
    currentShape++;
  }
} else if (downPressed) {
  if (currentShape > 0) {
    currentShape--;
  }
}
}

function NewShape() {
  var type = $("#typeField").val();
  var x = parseInt( $("#xField").val() );
  var y = parseInt( $("#yField").val() );
  var width = parseInt( $("#widthField").val() );
  var color = $("#colorField").val();
  var stroke = parseInt( $("#strokeField").val() );

  shapes.push(new Shape(type, x, y, width, color, stroke));

  currentShape++;

  shapeInput = new InputValues(x, y, width, stroke);

  $("#currentShape").text("Current shape: " + currentShape);

  WriteShapeData();
}


function keyPressHandler(e){
  if(e.key == "d"){
    if (currentShape < shapes.length - 1) {
      currentShape++;
    }
  } 
  else if(e.key == "a"){
    if (currentShape > 0) {
        currentShape--;
    }
  }
}

function keyDownHandler(e) {
  if (e.key == "w") {
    upPressed = true;
  } else if (e.key == "s") {
    downPressed = true;
  } 
}

function keyUpHandler(e) {
  if (e.key == "w") {
    upPressed = false;
  } else if (e.key == "s") {
    downPressed = false;
  } 
}

var InputValues = function(x, y, width, stroke){
  this.x = x;
  this.y = y;
  this.width = width;
  this.stroke = stroke;
}

var Point = function(x, y) {
  this.x = x,
    this.y = y
}

var Shape = function(type, x, y, width, color, strokeWidth) {
  this.Color = color,
  this.MaxX = x + width,
  this.MinX = x,
  this.MaxY = y + width,
  this.MinY = y,
  this.Type = type,
  this.StrokeWidth = strokeWidth,
  this.p1 = new Point(this.MinX, this.MinY),
  this.p2 = new Point(this.MaxX, this.MinY),
  this.pastPoints = []
}

Shape.prototype.MovePoints = function(distance) {

  this.pastPoints.push({
    P1x: this.p1.x,
    P1y: this.p1.y,
    P2x: this.p2.x,
    P2y: this.p2.y
  });

  var xSideP1 = (this.p1.x <= this.MinX) ? "left" : "";
  xSideP1 = (this.p1.x >= this.MaxX) ? "right" : xSideP1;

  var ySideP1 = (this.p1.y <= this.MinY) ? "up" : "";
  ySideP1 = (this.p1.y >= this.MaxY) ? "down" : ySideP1;

  var xSideP2 = (this.p2.x <= this.MinX) ? "left" : "";
  xSideP2 = (this.p2.x >= this.MaxX) ? "right" : xSideP2;

  var ySideP2 = (this.p2.y <= this.MinY) ? "up" : "";
  ySideP2 = (this.p2.y >= this.MaxY) ? "down" : ySideP2;

  if (this.Type == "normal" || this.Type == "Normal") {
    switch (xSideP1) {
      case "right":
        if (this.p1.y > this.MinY) this.p1.y -= distance;
        break;
      case "left":
        if (this.p1.y < this.MaxY) this.p1.y += distance;
        break;
      default:
        break;
    }
    switch (ySideP1) {
      case "up":
        if (this.p1.x > this.MinX) this.p1.x -= distance;
        break;
      case "down":
        if (this.p1.x < this.MaxX) this.p1.x += distance;
        break;
      default:
        break;
    }
    switch (xSideP2) {
      case "right":
        if (this.p2.y > this.MinY) this.p2.y -= distance;
        break;
      case "left":
        if (this.p2.y < this.MaxY) this.p2.y += distance;
        break;
      default:
        break;
    }
    switch (ySideP2) {
      case "up":
        if (this.p2.x > this.MinX) this.p2.x -= distance;
        break;
      case "down":
        if (this.p2.x < this.MaxX) this.p2.x += distance;
        break;
      default:
        break;
    }
  } else if (this.Type == "eye" || this.Type == "Eye") {

    switch (xSideP1) {
      case "right":
        if (this.p1.y > this.MinY) this.p1.y -= distance;
        break;
      case "left":
        if (this.p1.y < this.MaxY) this.p1.y += distance;
        break;
      default:
        break;
    }
    switch (ySideP1) {
      case "up":
        if (this.p1.x > this.MinX) this.p1.x -= distance;
        break;
      case "down":
        if (this.p1.x < this.MaxX) this.p1.x += distance;
        break;
      default:
        break;
    }
    switch (xSideP2) {
      case "right":
        if (this.p2.y > this.MinY) this.p2.y -= distance;
        break;
      case "left":
        if (this.p2.y < this.MaxY) this.p2.y += distance;
        break;
      default:
        break;
    }
    switch (ySideP2) {
      case "up":
        if (this.p2.x > this.MinX) this.p2.x -= distance;
        break;
      case "down":
        if (this.p2.x < this.MaxX) this.p2.x += distance;
        break;
      default:
        break;;
    }
    if (ySideP1 == "down" && xSideP2 == "left") {
      this.p1.x = this.MinX;
      this.p2.x = this.MaxX;
      this.p2.y = this.MaxY;
    } else if (ySideP2 == "up" && xSideP1 == "right") {
      this.p1.x = this.MinX;
      this.p1.y = this.MinY;
    }
  } else {
    ctx.font = "30px Arial";
    ctx.fillStyle = "#000000";
    ctx.fillText("Shape unavailable", 50, 50);
  }
}

Shape.prototype.DrawLine = function() {
  ctx.beginPath();
  ctx.strokeStyle = this.Color;
  ctx.lineWidth = this.StrokeWidth;
  ctx.moveTo(this.p1.x, this.p1.y);
  ctx.lineTo(this.p2.x, this.p2.y);
  ctx.stroke();
}

Shape.prototype.Erase = function() {
  if (this.pastPoints.length > 0) {
    var key = this.pastPoints.length - 1;
    var points = this.pastPoints.pop();
    var p1x = points.P1x;
    var p1y = points.P1y;
    var p2x = points.P2x;
    var p2y = points.P2y;

    DrawCircle(this.p1.x, this.p1.y, "#eee", 5);
    DrawCircle(this.p2.x, this.p2.y, "#eee", 5);

    this.p1.x = p1x;
    this.p1.y = p1y;
    this.p2.x = p2x;
    this.p2.y = p2y;

    ctx.beginPath();
    ctx.strokeStyle = "#eee"
    ctx.lineWidth = this.StrokeWidth + 2;
    ctx.moveTo(p1x, p1y);
    ctx.lineTo(p2x, p2y);
    ctx.stroke();
  }
}

function DrawCircle(x, y, color, width) {
  ctx.beginPath();
  ctx.fillStyle = color;
  ctx.arc(x, y, width, 0, 2 * Math.PI);
  ctx.fill();
}

function WriteShapeData() {
  var myString = "";
  for (var key1 in shapes) {
    myString += "<div class=\"col-sm-4 shape-data\"> <p>"
    myString += "Shape: " + key1;
    var limit = 7;
    var count = 0;
    for (var key2 in shapes[key1]) {
      if (count < limit) {
        myString += "<br>" + key2 + ": " + shapes[key1][key2];
      }
      count++;
    }
    myString += "</p></div>";
  }
  $("#shapeData").html(myString);
}

/*function WritePointData() {
  var myString = "Point Data" + "<br><br>" + "Point 1:";
  for (var key1 in shapes) {
    for (var key2 in shapes[key1].p1) {
      myString += "<br>" + key2 + ": " + shapes[key1].p1[key2];
    }
    myString += "<br><br>" + "Point 2:"
    for (var key2 in shapes[key1].p2) {
      myString += "<br>" + key2 + ": " + shapes[key1].p2[key2];
    }
  }
  myString += "<br><br>" + "Frames: " + countFrames +
    "<br>" + "Keypress: " + upPressed + " " + downPressed + " " + upPressed + shapes.length;
  document.getElementById("p1").innerHTML = myString;
  setTimeout(WritePointData, 100)
}*/







