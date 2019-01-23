function getDocHeight() {
    var D = document;
    return Math.max(
        D.body.scrollHeight, D.documentElement.scrollHeight,
        D.body.offsetHeight, D.documentElement.offsetHeight,
        D.body.clientHeight, D.documentElement.clientHeight
    )
}

function amountScrolled() {
    var scrollTop = window.pageYOffset;
    var docHeight = getDocHeight();
    var winHeight = window.innerHeight;
    var trackLength = docHeight - winHeight

    var pctScrolled = Math.floor(scrollTop / trackLength * 100);
    return pctScrolled;
}

function changeImage(pctScrolled) {
    if (pctScrolled < 10) {
        document.getElementById("locationText").innerHTML = "Middle East, Year 1190";
    } else if (pctScrolled < 25) {
        document.getElementById("locationText").innerHTML = "Italy, Year 1476";
    } else if(pctScrolled < 42){
        document.getElementById("locationText").innerHTML = "Constantinopel, Year 1510";
    } else if (pctScrolled < 58) {
        document.getElementById("locationText").innerHTML = "America, Year 1754";
    } else if (pctScrolled < 72) {
        document.getElementById("locationText").innerHTML = "America, Year 1715";
    } else if (pctScrolled < 86) {
        document.getElementById("locationText").innerHTML = "Paris, Year 1790";
    } else if (pctScrolled < 97) {
        document.getElementById("locationText").innerHTML = "London, 1868";
    } else {
        document.getElementById("locationText").innerHTML = "India/China/Russia, Year 1841/1526/1918";
    }
}

window.addEventListener("scroll", function () {
    changeImage(amountScrolled());
});
