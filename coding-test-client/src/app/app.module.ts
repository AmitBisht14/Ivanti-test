import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { Problem1Component } from './problem1/problem1.component';
import { Problem2Component } from './problem2/problem2.component';

@NgModule({
  declarations: [
    AppComponent,
    Problem1Component,
    Problem2Component
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
