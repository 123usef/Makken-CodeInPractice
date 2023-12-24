// one line Comment 

/*
    Multi Line Comment
*/
// console.log("hello world from JavaScript");
// Datatypes inside Javascript
// primitive Datatypes 
// numbers , string , boolean , null , undefined , 
// Non Primitive Datatype : 
// array , list , object 
//------------------------------------------------
// Es5 :
// var x = "hello";
// console.log(typeof(x));
// var x = 10 ;
// //---------
// // Es6 :
// let y = true ; 
// // let y = false ;
// const z = 3.14 ;
// let arr = [1,'a',"hello" , true , 1.3];
// let StudentInfo = {
//     name : "yousif",
//     age : 26 , 
//     address : "Alexandria"
// };
// // console.log(obj.name)

// let msg = "hello World " ; 
// let msg2 = "from Javascript" ;
// let obj = {
//     name : "yousif",
//     age : 26 , 
//     address : "Alexandria"
// }
// console.log(`${msg} ${msg2} ${obj.name} \n welcome to new World  `);
// //--------------------------------------
// let num  = "3.14"
// //type Casting 
// let cstnum = Number(num);
// console.log(typeof(cstnum))
// String() , Boolean()  ,Number() 
// string ==> array of Characters
//----------------------------------
//Mathematical Operators 
// + ,- , * , / , % , **
// console.log(3 * 4);
// console.log(3 + 4);
// console.log(3 - 4);
// console.log(3 / 4);
// console.log(10 % 2);
// console.log(2**2);
// //------------------------------
// console.log("hello " + 2);
// //----------------------------------
// // &&  ,  || , !
// let age = 19
// if(age >20){
//     console.log("You are Allowed to enter the Party ")
// }else {
//     console.log("dddddddddd");
// }
// // if(){

// // }else if() {

// // }else {

// // }
// if(age > 19 || true){
//     console.log("Doors is Open For You ")
// }
// let val  = age > 19 ? true : false ;
// if(val) {
//     console.log("hello world from ternary ");

// }
//---------------------------------------
// Prototype
// function Print() {
//     console.log("hello World");
// }
// function Printline() {
//     return "hello world \n";
// }

// function sum(x , y){
//     console.log(x+y);
// }

// function Multiply(x , y=1){
//     return x*y;
// }

// Print();
// console.log(Printline());
// sum(3,4)

// console.log( Multiply(3) )
// console.log( Multiply(3 , 4) )
// let func = function (x , y) {
//     return x / y ;
// }
// console.log(func(3, 4)) ;
// let xxy =  () => "hello world";
// // console.log(xxy);
// // let func2 = () => "hello world";
// //-----------------------------------------
// let isEven =  (x) => {
//     return (x % 2 == 0)
// }

// -------------------------------------------
// interactive 
// alert("website is Hacked ")
// let userValue = prompt("enter a Number : ");
// alert(isEven(userValue)? "number is even" : "number is odd");
// let flag = confirm("do you confirm to be hacked ");
// console.log(flag)

// is Divisble by 3 

//Loops 
// --------
// while  , for  , do While  

// for (let i = 1; i < 10; i++) {

//     // console.log( " * " * i);
//    console.log( "*".repeat(i)); 
// }
// "*".repeat()
// console.log(`${}`)
// let userInput = Number(prompt("enter a number : "));
// while (userInput) {
// alert(isEven(userInput)? "number is even" : "number is odd");
//  userInput =  Number(prompt("enter a number : "));
    
// }

// let userInput = prompt("enter a number : ");
// while (userInput) {
// alert(isEven(userInput)? "number is even" : "number is odd");
//  userInput =  prompt("enter a number : ");
    
// }

// console.log(Boolean(0));
// do{
//     console.log("hello world from falsy do while ");
// }while(false)


// while(false){

//     console.log("hello from Falsy while ");
// }
// // ---------------------------------------------