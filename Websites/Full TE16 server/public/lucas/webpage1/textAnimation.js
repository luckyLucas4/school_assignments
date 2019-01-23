var text1 = "JavaScripted";
var text2 = "";
var count1 = 0;
var count2 = 0;
var direction2 = true;

function Write1(text) {
	document.getElementById("p1").innerHTML = text;
}

function Write2(text) {
	document.getElementById("jagVetInne").innerHTML = text;

}

var id = setInterval(Draw, 200);

function Draw(){
	var limit1 = 46;
	var limit2 = 10;
	
	text1 = "";
	text2 = "";
	
	for (var i = 0; i < count1; i++){
		text1 += "[] ";
	}
	
	text1 += "JavaScripteded";

	for (var i = limit1; i > count1; i--){
        text1 += "[] ";
    }
	
	for (var i = 0; i < count2; i++){
		text2 += "<br>";
	}
	
	Write1(text1);
	Write2(text2);
	
	if(count1 < limit1){
	    count1++;
	} else {
		count1 = 0;
	}
	
	if(count2 == 0){
		direction2 = true;
	}
	
	if(count2 < limit2 && direction2 == true){
	    count2++;
	} else {
		direction2 = false;
		count2--;
	}
}

