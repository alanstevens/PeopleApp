import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-card-list',
  templateUrl: './card-list.component.html',
  styleUrls: ['./card-list.component.css']
})
export class CardListComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  person = {
    age: 27,
    city: "Mobile",
    email: "posuere.enim@laciniaSedcongue.net",
    firstName: "Axel",
    interests: "blue",
    lastName: "Jacobs",
    photo: "https://randomuser.me/api/portraits/men/0.jpg",
    state: "Alabama",
    streetAddress: "9975 Mi Rd.",
    zip: "35569"
  }
}
