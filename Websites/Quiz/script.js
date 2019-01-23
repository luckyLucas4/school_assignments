var questions = [
    {
        nr : 0,
        title: "What's that ticking noise?",
        alternatives: ["A clock", "Raindrops", "Squirrels", "Time bomb"],
        correctAnsw: 2,
        answer: -1,
        points: 37
    },
    {
        nr : 1,
        title: "What's my name?",
        alternatives: ["Bert", "Hagbard", "Lucas", "Kjell", "Clas Ohlson"],
        correctAnsw: 0,
        answer: -1,
        points: 42
    },
    {
        nr : 2,
        title: "?",
        alternatives: ["Yes", "No", "Maybe", "Of course", "A little"],
        correctAnsw: 2,
        answer: -1,
        points: 101
    },
    {
        nr : 3,
        title: "What color is this text?",
        alternatives: ["Red", "Green", "Blue", "Black", "Orange", "Gray"],
        correctAnsw: -1,
        answer: -1,
        points: 255,
        colorChange: true
    }
];

var qNumber = -1;

$(document).ready(function(){
    $("#button").click(nextQuestion);
    $("#question").hide();
    $("#myForm").hide();
    $("#table").hide();
    colorChange();
});

function nextQuestion(){

    $("#button").text("Next question!")
    $("#question").slideUp("slow");

    $("#myForm").slideUp("slow", function(){
        if(qNumber >= 0 && qNumber < questions.length){
            if(document.forms["myForm"]["question"].value != undefined){
                questions[qNumber].answer = document.forms["myForm"]["question"].value;
                if(questions[qNumber].title == "What color is this text?"){
                    questions[qNumber].correctAnsw = colorCount1 + 1;
                }
                //alert(document.forms["myForm"]["question"].value);

            }
        }
        qNumber++;
        if(qNumber < questions.length){
            $("#myForm").html("");
            for(var i = 0; i < questions[qNumber].alternatives.length; i++){
                $("#myForm").html($("form").html() + "<input type=\"radio\" name=\"question\" value=\"" + i +  "\" id=\"radio" + i + "\"><label for=\"radio" + i + "\"><span></span>" + questions[qNumber].alternatives[i] + "</label><br>");
            }
            $("#myForm").slideDown("slow");
            $("#question").text(questions[qNumber].title).slideDown("slow");

        }
        else{
            $("#button").text("Results");
            $("#button").click(summarize);
        }
    });
}

function summarize(){
    var total = 0;
    $("#table").html( $("#table").html() + "<tr> <td>Question: </td> <td>Answer: </td> <td>Correct: </td> <td>Points: </td>");
    for(var i = 0; i < questions.length; i++){
        var answer;
        var points = 0;
        if(questions[i].answer >= 0){
            answer = questions[i].alternatives[questions[i].answer];

            if(questions[i].answer == questions[i].correctAnsw + 1){
                points = questions[i].points;
                total += points;
            }
        }
        else{
            answer = "No";
        }
        $("#table").html( $("#table").html() + "<tr>" + 
            "<td>" + (questions[i].nr + 1) + "</td>" + 
            "<td>" + answer + "</td>" + 
            "<td>" + questions[i].alternatives[questions[i].correctAnsw + 1] + "</td>" + 
            "<td>" + points + "</td></tr>");
    }
    $("#table").html( $("#table").html() + "<tr></tr><tr><td>Total points: </td><td>"  + total + "</td></tr>");
    $("#table").slideDown("slow");
    $("#button").unbind();
    $("#button").text("Play again!").click(function(){
        location.reload();
    })
}


colorText = document.getElementById("color-change1");

var colors = ["red", "green", "blue", 
"black", "orange", "grey", ];

var colorCount1 = 0;
//var colorCount2 = 1;

function colorChange() {

    if(colorCount1 > colors.length - 1){
        colorCount1 = 0;
    }
    /*if(colorCount2 > colors.length - 1){
        colorCount2 = 0;
    }*/
    document.getElementById("question").style.color = colors[colorCount1];
    //document.getElementById("body").style.backgroundColor = colors[colorCount2];
    colorCount1++;
    //colorCount2++;
    setTimeout(colorChange, 800);
}