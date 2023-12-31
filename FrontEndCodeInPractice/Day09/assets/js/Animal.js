class Animal {
    constructor(Name ){
        this.Name = Name ;
    }
    print(){
        console.log(`${this.Name} is an Animal `)
    }
}

class Rabit extends Animal {
    constructor(Name , Speed){
        super(Name) ;
        this._Speed = Speed ;
    }
    // set Name(name){
    //     this._Name = name;
    // }

    // get Name(){
    //    return this._Name ;
    // }
    // set Attributename(){
    //     logic
    // }
    get Speed(){
        return this._Speed ;
    }
    print(){
        // console.log("from child")
        // super.print();
        // console.log("from child")
        console.log(`${this.Name} is an animal with speed ${this.Speed}`)
    }

    run(){
        this.print();
        console.log(`${this.Name} runs  with speed ${this.Speed} m/h`);
    }
}

let rabit = new Rabit("bondo2" , 20);
// rabit.Name = "booka";
// rabit.print();
// rabit.Name("booka");
console.log(rabit._Name)
console.log(rabit)
console.log(rabit.Speed) 
rabit.run();