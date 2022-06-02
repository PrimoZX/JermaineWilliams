//named fuction
window.onload = BasicFunction();
function BasicFunction(){
    console.log ("Calling named function");
}

// anonymous function - single use only and they are created and called just once
var li = document.getElementById("anonymous").value
li.onclick = function(){
    console.log("Calling anonymous function")
}
// window.onload = (function(){
//     console.log ("JS working");
// })()

// arrow function
// window.onload = () => console.log ("Arrow function working")

//IIFE function, arrow function
(() => confirm.log("IIFE function working"))()

//prototype function - used for inhertiance through functions
function prototypeFunction(){
    console.log(prototypeFunction.prototype)
    prototypeFunction.prototype.name = "something"
}

//callback function
function greeting(name){
    console.log("Hello " + name)
}

function Input (greeting){
    var name = prompt ("Please enter your name: ")
    greeting(name)
}