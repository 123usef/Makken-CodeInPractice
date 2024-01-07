import User  , { PrintName ,  PrintAge} from "./User.js";
// import * as mod from "./User.js" ;
let user  =  new User("ahmed" , 24);
PrintName(user.name);
PrintAge(user.age);