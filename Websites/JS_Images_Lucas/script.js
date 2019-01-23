var counter = 2;

function changeImage() {
    var image = document.getElementById('myImage');
    var path = "Images/img" + counter + ".jpg"
    image.src = path;
    if(counter >= 6){
        counter = 1;
    }
    counter++;
}