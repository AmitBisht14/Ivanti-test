import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { of } from 'rxjs';
import { AppModule } from '../app.module';
import { DataService } from '../data.service';
import { TraingleRowColumns, TriangleVertices } from '../interfaces/triangle.interface';

import { Problem1Component } from './problem1.component';

describe('Problem1Component', () => {
  let component: Problem1Component;
  let fixture: ComponentFixture<Problem1Component>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ AppModule]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(Problem1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('+ should create problem1', () => {
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

    expect(fixture.componentInstance.coordinateA).toEqual(undefined);
    expect(fixture.componentInstance.coordinateB).toEqual(undefined);
    expect(fixture.componentInstance.coordinateC).toEqual(undefined);

    spyOn(dataServiceSpy, 'getDataFromRowColumn').withArgs(traingleRowColumns).and.returnValue(of(triangleVertices));
    
    // Act
    fixture.componentInstance.form.value.row = traingleRowColumns.row;
    fixture.componentInstance.form.value.column = traingleRowColumns.column;
    fixture.componentInstance.calculateTriangle();
    fixture.detectChanges();
    
    // Expect
    expect(fixture.componentInstance.coordinateA).toEqual(triangleVertices.aX + ', ' + triangleVertices.aY);
    expect(fixture.componentInstance.coordinateB).toEqual(triangleVertices.bX + ', ' + triangleVertices.bY);
    expect(fixture.componentInstance.coordinateC).toEqual(triangleVertices.cX + ', ' + triangleVertices.cY);
  });
});
