import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { Problem1Component } from './problem1/problem1.component';
import { Problem2Component } from './problem2/problem2.component';


const routes: Routes = [
  { path: '', component: HomeComponent},
  { path: 'problem1', component: Problem1Component},
  { path: 'problem2', component: Problem2Component},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
