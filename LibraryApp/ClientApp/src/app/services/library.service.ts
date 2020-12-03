import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class LibraryService {
  constructor(private http: HttpClient) { }

 
  getallBooks() {

    return this.http.get('./Library');
  }



}
