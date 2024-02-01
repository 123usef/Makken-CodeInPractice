import { Component } from '@angular/core';
import { User } from '../../DataStore/Models/user';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-main',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './main.component.html',
  styleUrl: './main.component.scss'
})
export class MainComponent {
  UserValue : User ;
  constructor(){
    this.UserValue = new User("yousif Mohamed" , 26 , "Male" , "Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque placeat exercitationem maiores qui iure adipisci enim rerum saepe fuga laudantium.",['react' , "angular" , ".Net" , "php" ,"python"] ) ;
  }
  

}
