import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { TraingleRowColumns, TriangleVertices } from './interfaces/triangle.interface';
@Injectable({
  providedIn: 'root'
})
export class DataService {
  private apiUrl: string = 'https://localhost:44332';
  constructor(private http: HttpClient) { }

  getDataFromVertices(triangleVertices: TriangleVertices): Observable<TraingleRowColumns> {
    const url = '/Shape/GetDataFromVertices?aX='+ triangleVertices.aX + '&aY='+ triangleVertices.aY + '&bX=' + triangleVertices.bX + '&bY=' + triangleVertices.bY 
              + '&cX=' +  triangleVertices.cX + '&cY=' +  triangleVertices.cY;
    let response: TraingleRowColumns = {} as TraingleRowColumns;
    return this.http.get<TraingleRowColumns>(this.apiUrl + url);
  }
  getDataFromRowColumn(rowColumnDetails: TraingleRowColumns): Observable<TriangleVertices> {
    const url = '/Shape/GetDataFromRowColumn?Row=' + rowColumnDetails.row + '&Column=' + rowColumnDetails.column;
    return this.http.get<TriangleVertices>(this.apiUrl + url);
  }
}
