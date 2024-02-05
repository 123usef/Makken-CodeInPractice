import { Routes } from '@angular/router';
import { MainComponent } from './Components/main/main.component';
import { CategoriesComponent } from './Components/categories/categories.component';


export const routes: Routes = [
    {path:"" , component:MainComponent},
    {path:"/categories" , component:CategoriesComponent}


];

