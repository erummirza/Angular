import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';

import { Position } from "./position";

@Injectable({
  providedIn: 'root'
})
export class PositionsService {

  //private apiURL = "https://localhost:44384/api"; // CHANGE THIS WITH YOUR BACKEND URL
  private apiURL = "https://localhost:7098/api/Players"; // CHANGE THIS WITH YOUR BACKEND URL

  constructor(private httpClient: HttpClient) { }

  getPositions(): Observable<Position[]> {
    return this.httpClient.get<Position[]>(this.apiURL + '/positions')
      .pipe(
        catchError(this.errorHandler)
      );
  }

  errorHandler(error) {
    let errorMessage = '';

    if (error.error instanceof ErrorEvent) {
      errorMessage = error.error.message;
    } else {
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    return throwError(errorMessage);
  }
} 
