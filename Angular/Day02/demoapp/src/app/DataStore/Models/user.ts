export class User {
    //  name : string ; 
    constructor(public name : string , public age : number ,public Gender :string , public Describtion : string , public skills :string[] ){
      this.name = name ;
      this.age = age  ;
      this.Gender = Gender ;  
      this.Describtion = Describtion;
    this.skills=skills;
     } 
}
