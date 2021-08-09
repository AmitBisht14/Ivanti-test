import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-problem2',
  templateUrl: './problem2.component.html',
  styleUrls: ['./problem2.component.scss']
})
export class Problem2Component implements OnInit {

  showEven = false;
  textToShow = "test";

  constructor() { }
  ngOnInit(): void {
  }

}
