/*

    this keyword search for the parent of the object to gain 
    accessability to the scope 
    window object is the parent of all scopes so when we use this keyword 
    it will search for the global scope as its not found in the object scope 
    and there is no username variable in the global scope 


    for the old fix we used to refrence this to the object scope to refer to the object scope 
    
    //updates for javascript 

    arrow function reroute the this to the local scope 
---------------------------------------------------------------
    originally arrow function has no this keyword so it works with automatic binding to the nearest 
    scope even if inside a function or declared globally 


*/







var obj = {
    username: "joe" , 
    display : function () {
        var _self = this ; //old fix 
        setTimeout(function(){
            // console.log(this.username)
            console.log(_self.username)
        },2000);
        
    }
}

var obj = {
    username: "joe" , 
    display : function () {
        // var _self = this ; //old fix 
        setTimeout(()=>{
            // console.log(this.username)
            console.log(this.username)
        },2000);
        
    }
}

var usrname = "ECMA6" ; 
var newfun = ()=> this.usrname;

var obj = {
    username: "joe" , 
    display : function () {
        // var _self = this ; //old fix 
        setTimeout(()=>{
            // console.log(this.username)
            console.log(this.username)
        },2000);
        
    }
    ,objnw : newfun //ecma6 will be displayed lexical binding 
}

