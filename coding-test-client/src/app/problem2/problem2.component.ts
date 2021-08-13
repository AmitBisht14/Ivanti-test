import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataService } from '../data.service';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';
import { TriangleVertices } from '../interfaces/triangle.interface';
@Component({
  selector: 'app-problem2',
  templateUrl: './problem2.component.html',
  styleUrls: ['./problem2.component.scss']
})
export class Problem2Component implements OnInit {

  showEven = false;
  textToShow: string;
  showError = false;
  showResult = false;
  errorMessage: string;
  form = new FormGroup({
    "aX": new FormControl("", Validators.required),
    "aY": new FormControl("", Validators.required),
    "bX": new FormControl("", Validators.required),
    "bY": new FormControl("", Validators.required),
    "cX": new FormControl("", Validators.required),
    "cY": new FormControl("", Validators.required),
  });

  constructor(private dataService: DataService) { }
  ngOnInit(): void {
  }

  calculateTriangle() {
    const inputData = this.form.value;

    let triangleVertices: TriangleVertices = {} as TriangleVertices;
    triangleVertices.aX = inputData.aX;
    triangleVertices.aY = inputData.aY;
    triangleVertices.bX = inputData.bX;
    triangleVertices.bY = inputData.bY;
    triangleVertices.cX = inputData.cX;
    triangleVertices.cY = inputData.cY;

    this.dataService.getDataFromVertices(triangleVertices).subscribe(s => {
      this.showError = false;
      this.showResult = true;
      this.showEven = s.column > 1 && s.column % 2 === 0;
      this.textToShow = s.row + s.column;
    }, error => {
      this.showResult = false;
      this.showError = true;
      this.errorMessage = "Invalid input or incorrect data provided"
      console.log(error);
    });
  }
}
