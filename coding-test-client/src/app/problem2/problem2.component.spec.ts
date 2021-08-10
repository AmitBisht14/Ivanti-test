import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { AppModule } from '../app.module';
import { DataService } from '../data.service';
import { TraingleRowColumns, TriangleVertices } from '../interfaces/triangle.interface';

import { Problem2Component } from './problem2.component';

describe('Problem2Component', () => {
  let component: Problem2Component;
  let fixture: ComponentFixture<Problem2Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ AppModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Problem2Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('+ should create problem2', () => {
    expect(component).toBeTruthy();
  });

  it('+ should calculate Triangle based on input Data', () => {
    // Assert
    let dataServiceSpy: DataService = TestBed.inject(DataService);
    let triangleVertices: TriangleVertices = {} as TriangleVertices;
    triangleVertices.aX = 0;
    triangleVertices.aY = 0;
    triangleVertices.bX = 0;
    triangleVertices.bY = 10;
    triangleVertices.cX = 10;
    triangleVertices.cY = 10;

    let traingleRowColumns: TraingleRowColumns = {} as TraingleRowColumns;
    traingleRowColumns.row = 'A';
    traingleRowColumns.column = 1;
    spyOn(dataServiceSpy, 'getDataFromVertices').withArgs(triangleVertices).and.returnValue(of(traingleRowColumns));
    
    fixture.componentInstance.form.value.aX = triangleVertices.aX;
    fixture.componentInstance.form.value.aY = triangleVertices.aY;
    fixture.componentInstance.form.value.bX = triangleVertices.bX;
    fixture.componentInstance.form.value.bY = triangleVertices.bY;
    fixture.componentInstance.form.value.cX = triangleVertices.cX;
    fixture.componentInstance.form.value.cY = triangleVertices.cY;
    // Act
    fixture.componentInstance.calculateTriangle();
    fixture.detectChanges();
    // Expect
    expect(fixture.componentInstance.textToShow).toEqual(traingleRowColumns.row + traingleRowColumns.column);
    expect(fixture.componentInstance.showEven).toEqual(false);
  });
  

});
