import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { TraingleRowColumns, TriangleVertices } from './interfaces/triangle.interface';
@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor() { }

  getDataFromVertices(triangleVertices: TriangleVertices): Observable<TraingleRowColumns> {
    let response: TraingleRowColumns = {} as TraingleRowColumns;
    response.row = "A";
    response.column = 3 ;
    return of(response);
  }
  getDataFromRowColumn(rowColumnDetails: TraingleRowColumns): Observable<TriangleVertices> {
    let response: TriangleVertices = {} as TriangleVertices;
    response.aX = 0;
    response.aY = 0;
    response.bX = 0;
    response.bY = 10;
    response.cX = 10;
    response.cY = 10;
    return of(response);
  }
}
