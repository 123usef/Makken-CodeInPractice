$(document).ready(function(){
    // document.querySelector("#item1").addEventListener("click" ,(e)=>{
    //     e.target.style.display = "none" ;
    // })
    
    $("#item1").css({"border": "1px solid violet" , "height" : "10vh" , "width" :"50%" , "position" : "relative"});
   
    $("#btn").click(function(){
        $("#item1").animate({left:'70px'});
    })
    
    
})
