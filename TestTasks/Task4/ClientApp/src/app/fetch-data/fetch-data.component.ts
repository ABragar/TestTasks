import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public items: BusinessEntity1[];

  private http: HttpClient;
  private baseUrl: string
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  findItem(text: string): void {
    this.http.get<BusinessEntity1[]>(this.baseUrl + `api/SampleData/search/${text}`).subscribe(result => {
      this.items = result;
    }, error => console.error(error));
  }
}

interface BusinessEntity1 {
  Id: number;
  Name: string;
}
