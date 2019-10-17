import { Component, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-value',
  templateUrl: './value.component.html',
  styleUrls: ['./value.component.css']
})
export class ValueComponent implements OnInit {
  values: any;
  constructor(private _httpClient: HttpClient) {

   }

  ngOnInit() {
   this.getValues();
  }

  
  getValues() {
    return this._httpClient.get("http://localhost:5005/WeatherForecast").subscribe( response =>{
     this.values = response;
    }, error => {
     console.log(error);
    });
  }
}
