import { Injectable, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }
  getArticulate(): Observable<string> {
    return this.http.get<string>('http://localhost:7993/articulate');
  }
}
