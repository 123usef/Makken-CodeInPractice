// Document object Model 
//------------------------
// console.log(document.getElementsByTagName("div"));
// console.log(elements[2])
// // elements[1].innerHTML += "<h1> Hello from inner html  </h1>";
// elements[1].textContent += "<h1> Hello from inner html  </h1>";
//--------------------------------------------------
let tagName = document.getElementsByTagName("div"); // html Collection
let ClassName = document.getElementsByClassName("sec")
let idname = document.getElementById("uni");
let username = document.getElementById("username");
// idname.style.backgroundColor = "coral";
// idname.addEventListener("click" , ()=>{
    
// })

console.log(username);

username.addEventListener("change" , (e)=>{
    // console.log(username.value);
    console.log(e.target.value);
    console.log(username.value);

})
let flag = false ; 
idname.addEventListener("click" , (e)=>{
    
    console.log(e.target.ClassName);
    console.log(e.target);
    if(e.target.className == "headd" && flag == false ){
        idname.style.backgroundColor = "purple";
        idname.style.width = "50%";
        flag = true
    }else {
        idname.style.backgroundColor = "white";
        idname.style.width = "100%";
        flag = false
    }
})


