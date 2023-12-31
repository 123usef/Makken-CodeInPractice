// let delbtn = document.querySelector() 
let addform = document.querySelector("#add-book");
// console.log(addform)
let input = document.querySelector(".hola");
// console.log(input)
let addbtn = document.querySelector("button")
// console.log(addbtn)
let unorder = document.querySelector("ul");

let delspn = document.querySelectorAll(".delete");
let cheko = document.querySelector("#hide");

addbtn.addEventListener("click" , function(e){
    //step 1 -  prevent reload behaviour 
    e.preventDefault();
    //step 2 - take user value from input 
    uservalue = input.value ; 
    //step 3  verfication as the value is not ""
    if(uservalue != "" ){
    //step 4 creating elements    
        let lst =  document.createElement("li");
        
        let spn = document.createElement("span");
        let del = document.createElement("span");

        lst.appendChild(spn);
        lst.appendChild(del);

        spn.classList.add("name");
        del.classList.add("delete");

        // console.log(lst);
        spn.textContent = uservalue;
        del.textContent = "delete";

        unorder.appendChild(lst);
        
        

    }   
    
    input.value = ""
    

})
//delete functionalities

// for (let i = 0; i < delspn.length; i++) {

//    delspn[i].addEventListener("click" , function(e){

//     // console.log(delspn[i].parentElement);

//     let prntli = delspn[i].parentElement;

//     unorder.removeChild(prntli);

//    })
    
// }
// let item =  document.querySelector("ul");
unorder.addEventListener("click" , function(e){
    if(e.target.className == "delete"){

        listparent = e.target.parentElement;

        // console.log(listparent);
        unorder.removeChild(listparent)

    }
})

cheko.addEventListener("change" , function(e){
    if(cheko.checked){
        unorder.style.display = "none";
    }
    else{
        unorder.style.display = "block";
    }
})