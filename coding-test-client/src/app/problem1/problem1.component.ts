import { Component, OnInit } from '@angular/core';
@Component({
  selector: 'app-problem1',
  templateUrl: './problem1.component.html',
  styleUrls: ['./problem1.component.scss']
})
export class Problem1Component implements OnInit {

  coordinateA: string;
  coordinateB: string;
  coordinateC: string;

  constructor() { }

  ngOnInit(): void {
  }

}
