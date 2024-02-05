import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router'; //url
import { HeaderComponent } from './Components/header/header.component';
import { FooterComponent } from './Components/footer/footer.component';
import { SidebarComponent } from './Components/sidebar/sidebar.component';
import { MainComponent } from './Components/main/main.component';
//decortaor
@Component({
  selector: 'app-root',//directive
  standalone: true,
  imports: [
    RouterOutlet,
    
    
    HeaderComponent,
    FooterComponent,
    SidebarComponent,
    MainComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'yousif';
}

