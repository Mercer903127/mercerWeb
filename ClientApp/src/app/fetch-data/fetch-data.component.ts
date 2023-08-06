import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public userInfos: UserInfo[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<UserInfo[]>(baseUrl + 'userinfo').subscribe(result => {
      this.userInfos = result;
    }, error => console.error(error));
  }
}

interface UserInfo {
  id: string;
  name: string;
  email: string;
}
