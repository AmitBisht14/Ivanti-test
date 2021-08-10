import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { DataService } from '../data.service';
import { TraingleRowColumns, TriangleVertices } from '../interfaces/triangle.interface';
@Component({
  selector: 'app-problem1',
  templateUrl: './problem1.component.html',
  styleUrls: ['./problem1.component.scss']
})
export class Problem1Component implements OnInit {

  coordinateA: string;
  coordinateB: string;
  coordinateC: string;

  form = new FormGroup({
    "row": new FormControl("", Validators.required),
    "column": new FormControl("", Validators.required),
  });

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
  }

  calculateTriangle() {
    const inputData = this.form.value;
    let traingleRowColumns: TraingleRowColumns = {} as TraingleRowColumns;
    traingleRowColumns.row = inputData.row;
    traingleRowColumns.column = inputData.column;

    this.dataService.getDataFromRowColumn(traingleRowColumns).subscribe(s => {
      this.coordinateA = s.aX + ', ' + s.aY;
      this.coordinateB = s.bX + ', ' + s.bY;
      this.coordinateC = s.cX + ', ' + s.cY;
    }, error => {
      console.log('error');
    });
  }
}
