import { Component, OnInit } from '@angular/core';
import { LibraryService } from '../services/library.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {

  loader: boolean = false;
  errorMess: string = '';
  books: any[] = [];
  criteriaList: any = ['name', 'author', 'isAvailable'];
  searchitem: string;
  searchText: string;
  searchCriteria: string[];
  selectedCriteria: any = null;
  searchProp: any;
  countryCheck: boolean = false;
  constructor(private libService: LibraryService) {
    
  }
  ngOnInit(): void {

    
   
    if (new Date().toString().includes("India")) {
      console.log(new Date().toString().includes("India"))
      this.countryCheck = true;

    }
    this.getallbooks();
  }

  getallbooks() {
    this.loader = true;
    this.libService.getallBooks().subscribe((res: any) => {
      this.loader = false;
      this.books = res;

    }, e => { this.loader = false; this.errorMess="Error in getting from library api" })
  }

  searchbook() {
    const obj = {};
    obj[this.searchProp] = this.searchText;
    this.selectedCriteria = obj;
  }

  clearCriteria() {
    this.selectedCriteria = null;
    this.searchText = '';
    this.searchProp = '';
  }
}
