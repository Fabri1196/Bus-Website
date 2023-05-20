import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';

import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { TravelTicket } from './travelTicket';

@Injectable({
    providedIn: 'root'
  })
export class TravelTicketService {
    
    // Backend
    private url = 'http://localhost:5000/api';

    httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json',
          'Host': 'http://localhost:4200',
        })
    };

    constructor(
      private http: HttpClient) {
    }

    getTickets(): Observable<TravelTicket[]> {
      return this.http.get<TravelTicket[]>(
        this.url + '/Tickets',
        this.httpOptions
      )
        // .pipe(catchError(this.handleError));
    }

}