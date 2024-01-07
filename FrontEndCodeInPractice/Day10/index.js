// let user = {
//     name : "yousif" , 
//     age : 26 , 
//     Gender : "Male"
// };
// //before EcmaScript 6 
// // let userName = user.name ; 
// // let userAge = user.age; 
// // let userGender = user.Gender ; 
// // let username , userAge  , UserGneder

// let { name : userName  ,  age: UserAge  ,  Gender: UserGender  } = user ;
// let { name   ,  age ,  Gender  } = user ;
// let { name: NickName  } = user ;
// let x = [2,3];
// //access By Index
// // x[0]
// // let [,z] = x
// let [y,z] = x ;
// console.log(z);

// console.log(userName , UserAge , UserGender);
// console.log(NickName  );
//---------------------------------------------
// function sum(x,y){
//     return x+y
// }

// let EnhancedSum = (x, y ,...args)=>{
//     sm = x+y ; 
//     if(args.length !=0){
//         for (let i = 0; i < args.length; i++) {
//             sm += args[i];

//         }
//     }

//     return sm;
// }

// console.log(EnhancedSum(2,3));
// console.log(EnhancedSum(2,3,5,6,7,8,9));

// let arr1 = ["one" , "two"] ;
// let arr2 = [ ...arr1 ,"three" , "four" , "five" , "six" , "seven" , "eight"];
// let arr3 = [1,2,3,4,5,6,7,8,9]
// console.log(arr1)
// console.log(arr2)

// console.log(EnhancedSum(...arr3))
// console.log(...arr3)
// console.log(EnhancedSum(1,2,3,4,5,6,7,8,9))

const items = [
    {name : "bike" , price : 100 },
    {name : "coffe Machine" , price : 200 },
    {name : "speaker" , price : 95 },
    {name : "tv" , price : 500 },
    {name : "bbq sauce" , price : 26 },
    {name : "small tv" , price : 250 },
    {name : "speaker" , price : 25 },
]
let FilteredItems = items.filter((item) =>{
    return item.price <=100 ;
})
console.log(FilteredItems)

let ItemNames = items.map((item) => {
    return item.name ;
})
console.log(ItemNames);

let searchspeaker = items.find((item) =>{
    return item.name == 'speaker';
})

console.log(searchspeaker);

items.forEach((item)=>{
    console.log(item.name , item.price);
})