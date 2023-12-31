class User{
    constructor(name  ,  age  , country , type = "Customer"){
        this.name = name ;
        this.age = age ;
        this.country = country ;
        this._type = type ;
    }
    // set type(value){
    //     if(value.length < 4){
    //         console.log("name is too short !");
    //     }else{
    //         this._type = value;
    //     }
    // }
    get type(){
        return this._type ;
    }
    getinfo(){
        console.log(` userName is => ${this.name} , \n 
                      userAge is ==> ${this.age}  ,\n
                      userCountry is ==> ${this.country} \n,
                      type is ==> ${this.type}`);
    }

}

let user = new User("Mohamed" , "Egypt" , "Alexandria" );
user.type = "admin"
console.log(user)
user.getinfo();