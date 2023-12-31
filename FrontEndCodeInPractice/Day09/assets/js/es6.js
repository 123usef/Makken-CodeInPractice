/*
    class soulmate of oop 
    * inhertance 
    * encapsulation
    * polymorphism 
    * Abstraction ==> not found in javascript
*/

class User{ 
     cnt  = 0 ; 

    constructor(name , address , age ){
        this.cnt+=1 ;
        this.name = name ;
        this.address = address ;
        this.age = age ;
    }
    
    getinfo(){
        console.log(`hello mr ${this.name} \n your age is ${this.age} \n from ${this.address}  `);
    }

}

let user = new User("Mohamed amin ","mnofia" , 23);
let user1 = new User();
console.log(user);
console.log(user1);

console.log(typeof User)
// user.name = "mahmoud";
user.getinfo();
