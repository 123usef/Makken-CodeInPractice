window.addEventListener("scroll", scrolling)
var btn = document.querySelector("button")
function scrolling (){
    if (scrollY >=1200){
       btn.style.display = "block"; 
    }else{
       btn.style.display = "none"; 
    }
  
}

btn.addEventListener("click",goUP)
function goUP (){
    scrollTo({top:0 ,left:0, behavior:"smooth"}) 
}


