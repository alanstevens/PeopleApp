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
  people =
    [
      {
        Age: 27,
        City: "Mobile",
        Email: "posuere.enim@laciniaSedcongue.net",
        FirstName: "Axel",
        Interests: "blue",
        LastName: "Jacobs",
        Photo: "https://randomuser.me/api/portraits/men/0.jpg",
        State: "Alabama",
        StreetAddress: "9975 Mi Rd.",
        Zip: "35569"
      },
      {
        Age: 19,
        City: "Bowling Green",
        Email: "Phasellus.ornare@nequeNullam.co.uk",
        FirstName: "Randall",
        Interests: "indigo, orange, blue, red",
        LastName: "Burke",
        Photo: "https://randomuser.me/api/portraits/men/1.jpg",
        State: "Kentucky",
        StreetAddress: "Ap #643-3424 Mattis. Street",
        Zip: "58791"
      },
      {
        Age: 46,
        City: "Grand Rapids",
        Email: "ac.urna@Donecnibhenim.org",
        FirstName: "Addison",
        Interests: "blue, indigo, yellow",
        LastName: "Harding",
        Photo: "https://randomuser.me/api/portraits/men/2.jpg",
        State: "Michigan",
        StreetAddress: "859-8038 Accumsan St.",
        Zip: "52558"
      },
      {
        Age: 50,
        City: "Oklahoma City",
        Email: "aliquet.molestie@Loremipsumdolor.edu",
        FirstName: "Xander",
        Interests: "red, violet, yellow, orange, blue",
        LastName: "Branch",
        Photo: "https://randomuser.me/api/portraits/men/3.jpg",
        State: "OK",
        StreetAddress: "4675 Elit Avenue",
        Zip: "22433"
      },
      {
        Age: 55,
        City: "Racine",
        Email: "at.lacus@Aliquamvulputate.co.uk",
        FirstName: "Aquila",
        Interests: "",
        LastName: "Mccarthy",
        Photo: "https://randomuser.me/api/portraits/men/4.jpg",
        State: "Wisconsin",
        StreetAddress: "P.O. Box 709, 1565 Consequat Rd.",
        Zip: "64296"
      }
    ]
}
