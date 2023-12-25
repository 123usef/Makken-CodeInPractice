// by tag name 
let alldivs = document.querySelectorAll("div");
let div = document.querySelector("div");
//by class name
let cls = document.querySelector(".sec-2");
//by id 
let iddd = document.querySelector("#uni")
//pracftical 
let head = document.querySelector("h3")
// console.log(alldivs)
// console.log(div)
// console.log(cls)
// console.log(iddd)
console.log("----------------------------------")
// console.log(head.innerHTML);
//---------------------------------------
// head.innerHTML += " from javascript";
// head.innerHTML = "<h2> Yousif Mohamed </h2> ";
// console.log(head.parentElement)
// let main = head.parentElement;
// main.style.backgroundColor = "coral";
// console.log(main);
// console.log(head.parentNode)
// head.textContent ==> CamalCase
//-------------------------------------
// console.log(head.nextElementSibling)
// console.log(head.previousElementSibling)
//--------------------------------------
let mni = head.parentElement ; 
// console.log(mni.children);

//----------------------------------
let anchor = document.querySelector("#uni1");
let ol  = document.createElement("ol");
mni.appendChild(ol);
anchor.addEventListener("click" , (e)=>{
    e.preventDefault();
    let li = document.createElement("li");
    li.textContent = "hello from dom ";
    ol.appendChild(li);
   

})

scroll