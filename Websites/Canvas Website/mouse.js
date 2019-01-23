/* (L�gg i html)
<script src="mouse.js"></script> <!-- (I head) -->

<!-- (I body) -->
<div id="drawingCanvas">
	<canvas onclick="addListeners()" id="myCanvas" width="500" height="300"></canvas>

	<p>Red value:</p>
	<input type="range" class="inputBar" id="redInput" max="255" value="0">
	<p>Green value:</p>
	<input type="range" class="inputBar" id="greenInput" max="255" value="0">
	<p>Blue value:</p>
	<input type="range" class="inputBar" id="blueInput" max="255" value="0">
	</div>
	*/
	function addListeners(){
		var canvas = document.getElementById('myCanvas');
		var context = canvas.getContext('2d');
		var mouseDown = false;
		
		document.getElementById("active").innerHTML = "Active";

	function writeMessage(message) {
			context.clearRect(0, 0, canvas.width, canvas.height);
			context.font = '18pt Calibri';
			context.fillStyle = 'black';
			context.fillText(message, 10, 25);
	}

	function drawDot(canvas, mousePos) {
		var context = canvas.getContext('2d');
		context.fillStyle = getColor();
		context.fillRect(mousePos.x,mousePos.y,5,5);
	}

	function getMousePos(canvas, evt) {
		var rect = canvas.getBoundingClientRect();
		return {
			x: evt.clientX - rect.left,
			y: evt.clientY - rect.top
		};
	}

	function getColor () {
		var red = document.getElementById("redInput").value;
		var green = document.getElementById("greenInput").value;
		var blue = document.getElementById("blueInput").value;
		
		return colorCompiler(red, green, blue);
	}

	function colorCompiler(red, green, blue) {
		return "rgb(" + red + "," + green + "," + blue + ")";
	}


	canvas.addEventListener('mousemove', function(evt) {
		var mousePos = getMousePos(canvas, evt);
		if(mouseDown) { drawDot(canvas, mousePos); }
	});
		
	canvas.addEventListener('mousedown', function(){
		mouseDown = true;}
	);
	canvas.addEventListener('mouseup', function(){
		mouseDown = false;}
	);
	canvas.addEventListener('mouseout', function(){
		mouseDown = false;}
	);
}