import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
  selector: 'app-add-info-component',
  templateUrl: './add-info.component.html'
})
export class AddInfoComponent {
  public url = "";

  public id = "";

  public name = "";

  public email = "";

  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.url = baseUrl;
  }

  public insertData() {
    this.http.post(this.url + 'addinfo', { "id": this.id, "name": this.name, "email": this.email }).subscribe((response)=>{
      console.log(response);      
    })
  }
}
