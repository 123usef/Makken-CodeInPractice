/*
    as we have learned function has several ways to be created 




*/


//named without parameters , return 
function func(){

}
//named with return without parameters
function func(){
    return "hole"
}

// named with parameters and return 

function func(pra1 , para2){
    return pra1 + para2;
}

// function like a variable 
var fun = function () {
    return "hello there"
}

// arrow function gave us the ability to remove function keyword 

var fun = () => {

}

//if single paramerter
var fun = x  =>  ' hello there' ; 


var fun = (x,y) => {
       console.log("hello there ") 
        return x+y ; 
    }