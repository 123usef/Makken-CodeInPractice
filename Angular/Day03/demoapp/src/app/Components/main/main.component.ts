import { Component } from '@angular/core';
import { User } from '../../DataStore/Models/user';
import { CommonModule } from '@angular/common';
import { Productlist } from '../../DataStore/Models/productlist';
import { Category } from '../../DataStore/Models/category';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-main',
  standalone: true,
  imports: [CommonModule , FormsModule],
  templateUrl: './main.component.html',
  styleUrl: './main.component.scss'
})
export class MainComponent {
  // UserValue : User ;
   prdlist  : Productlist[] ;
   catList : Category[] ;
   totalPrice : number ; 
  //  hamada :number =0;
   SelectedCategory:number = 0; 
  //  QuantityInput : number ; 
  constructor(){
    // this.QuantityInput = 0 ;
    // this.UserValue = new User("yousif Mohamed" , 26 , "Male" , "Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque placeat exercitationem maiores qui iure adipisci enim rerum saepe fuga laudantium.",['react' , "angular" , ".Net" , "php" ,"python"] ) ;
   
    this.totalPrice=0 ;
    this.prdlist = [
      {id : 1, name : "Tennis Ball" , Quantity:10 , price : 10 , imgaeUrl : "https://fakeimg.pl/300/" ,catId : 1 },
      {id : 2 , name : "BBQ grill" , Quantity:3 , price : 30 , imgaeUrl : "https://fakeimg.pl/300/" ,catId : 2 },
      {id : 3 , name : "camp house" , Quantity:5 , price : 350 , imgaeUrl : "https://fakeimg.pl/300/" ,catId : 3 },
      {id : 4 , name : "FootBall" , Quantity:15 , price : 3 , imgaeUrl : "https://fakeimg.pl/300/" ,catId : 1 },
    ]
    this.catList = [
      {id:1 , Name : "Sport"},
      {id:2 , Name : "Summer"},
      {id:3 , Name : "Camping"},
    ]
  }

  TotalPrice(price:number , qunatity :string){
    // let qty: number = Number(qunatity);
    // let qty: number = qunatity as number;
    let qty: number = parseInt(qunatity) ;

   let  dummy  = this.totalPrice ; 
    this.totalPrice =  price * qty +  dummy ;

  }

  ChangeCat(){
    this.SelectedCategory = 1;
  }
}

