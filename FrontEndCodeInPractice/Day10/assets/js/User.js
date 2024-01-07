export default class User{
    constructor(name , age){
        this.name = name ;
        this.age  = age ;
    }
}

//component 
export  function PrintName(name){
    console.log(`hello Mr ${name}`)
}

export  function PrintAge(age){
    console.log(`your age is  ${age}`)
}
