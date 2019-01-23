//Prevents the memory from setting up twice
var started = false;
//For counting the number of active squares
var counter = 0;
//For startup
var images = ["img/Blade.png", "img/Blade.png", "img/Sword.png", "img/Sword.png", "img/Fist.png", "img/Fist.png"];
var freeImages = [true, true, true, true, true, true];
//For holding the squares
var squares = [];

//Holds the values for the square
var Square = function (numberId, id, image) {
    this.numberId = numberId;
    this.id = id;
    this.image = image;
    this.active = false;
    this.cleared = false;
}

function memoryStart() {
    //Only start once
    if (started) return;

    //Distribute the images randomly
    for (var i = 0; i < 6; i++) {
        var image;
        var random = Math.floor((Math.random() * 6));

        //Loop until a free image is found
        while (true) {
            if (freeImages[random]) {
                image = images[random];
                freeImages[random] = false;
                break;
            }
            else random = Math.floor((Math.random() * 6));
        }
        //Put a new square into the array
        squares.push(new Square(i, "square" + i, image));
    }

    started = true;
    //Display new text on button
    document.getElementById("button1").innerHTML = "Reload page to start over!"
}

function memoryClick(elmnt, id) {
    
    //Flip the squares if there are 2 active
    if (counter >= 2) {
        for (var i = 0; i < squares.length; i++) {
            squares[i].active = false;
            if (squares[i].cleared == false) {
                document.getElementById(squares[i].id).style.backgroundImage = "url('img/AC logo.jpg')";
            }  
        }
        counter = 0;
        return;
    }

    //Change the image and mark as active
    elmnt.style.backgroundImage = "url('" + squares[id].image + "')";
    squares[id].active = true;

    //Put all the active squares in an array
    var activeSquares = [];
    for (var i = 0; i < squares.length; i++) {
        if(squares[i].active == true){
            activeSquares.push(squares[i]);
        }
    }

    //Check if there are two squares with the same image
    if (activeSquares.length == 2) {
        if (activeSquares[0].image == activeSquares[1].image) {

            //If so, mark them as cleared and unactive, reset counter
            squares[activeSquares[0].numberId].cleared = true;
            squares[activeSquares[0].numberId].active = false;

            squares[activeSquares[1].numberId].cleared = true;
            squares[activeSquares[1].numberId].active = false;
            counter = -1;
        }
    }
    counter++;
}