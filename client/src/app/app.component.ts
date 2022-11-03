import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'The Dating app';
  users: any;

  constructor(private http: HttpClient) {}
  
  ngOnInit(): void {
    this.getUsers();
  }

  // deprecated?
  // getUsers() {
  //   this.http.get("https://localhost:5001/api/users").subscribe((response: any) => {
  //     this.users = response;
  //   }, error => {
  //     console.log(error);
  //   });
  // }

  getUsers() {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next: response => {
        this.users = response;
      },
      error: error => console.log(error)
    })
  }
}