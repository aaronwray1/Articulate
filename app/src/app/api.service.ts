import { Injectable, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  getArticulate(): Observable<string> {
    return this.http.get('/articulate', { responseType: 'text' });
  }
}
