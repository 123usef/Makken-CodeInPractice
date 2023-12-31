
let userInput = prompt("enter your GitHub UserName : ");
const url = `https://api.github.com/users/${userInput}` ; 
//  fetch(url)
//  .then(respone => respone.json() )
//  .then(json => console.log(json) )
//  .catch(err => console.log(err))
let user = {
    name : "yousif",
    age : 23 , 
    address : "alexandria"
} 

/*
        let obj = await fetch(url , {
        method : "GET",
        headers:{
            'content-type' : 'application/json',
            'Authorization' :'token'
        }
        ,body: JSON.stringify(user)
          
        
     });

*/ 
async function loadData(){

     let obj = await fetch(url);
     let dtt = await obj.json();
     await console.log(dtt) ;
     
     document.querySelector("#main").innerHTML = `<img src= ${dtt.avatar_url} width= 50px ; hiegth = 50px /> <br> `;
   
 }
 loadData();
//  let dtt =  loadData() ;
// console.log(dtt.avatar_url);

