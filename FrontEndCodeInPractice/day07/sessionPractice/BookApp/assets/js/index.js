//selection 
//--------------- --
let  addbtn = document.querySelector("#add");
let bookname = document.querySelector("#bookname");
let booklist = document.querySelector("#booklist");
let dltbtns = document.getElementsByClassName("dlt");
let hd = document.querySelector("#Hide");
let upbtn = document.querySelector(".up");
console.log(dltbtns);
addbtn.addEventListener("click" , (e)=>{
    // e.target.preventDefault();
    let name  = bookname.value ;
    let li  = document.createElement("li");
    let spn1 = document.createElement("span");
    let spn2 = document.createElement("span");
    spn1.textContent = name ; 
    spn2.textContent = "Delete";
    li.className ="my-4" ;
    spn2.className +="btn btn-dark dlt "
    li.appendChild(spn1);
    li.appendChild(spn2);
    booklist.appendChild(li);
    bookname.value = ""
})

// for (let i = 0; i < dltbtns.length ; i++) {
//     dltbtns[i].addEventListener("click" , ()=>{
//         dltbtns[i].parentElement.remove();
//     })
    
// }

booklist.addEventListener("click" , (e)=>{
    // console.log(e.target)
    if(e.target.className == "btn btn-dark dlt "){

        e.target.parentElement.remove();
    }
})
let flag  = true ;
hd.addEventListener("click" , ()=>{
    if(flag){
    booklist.style.display = "none";
    hd.textContent = "Unhide" ; 
    flag = false    
    }else{
        booklist.style.display = "block";
        hd.textContent = "hide" ; 
        
        flag = true;
    }    
    // booklist.style.display = (booklist.style.display == "none") ? "block" : "none";
})

window.addEventListener("scroll" , ()=>{
    if(scrollY >= 50){
        upbtn.style.display = "block";

    }else {
        upbtn.style.display = "none";
    }
})

upbtn.addEventListener("click" , ()=>{
    scrollTo({
        top:0 ,
        behavior : "smooth"
    }) ;
})