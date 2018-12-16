import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PeopleService {

  constructor(private http: HttpClient) { }

  findPeople() {
    return PEOPLE;
  }
}

const PEOPLE =
  [
    {
      age: 27,
      city: 'Mobile',
      email: 'posuere.enim@laciniaSedcongue.net',
      firstName: 'Axel',
      interests: 'blue',
      lastName: 'Jacobs',
      photo: 'https://randomuser.me/api/portraits/men/0.jpg',
      state: 'Alabama',
      streetAddress: '9975 Mi Rd.',
      zip: '35569'
    },
    {
      age: 19,
      city: 'Bowling Green',
      email: 'Phasellus.ornare@nequeNullam.co.uk',
      firstName: 'Randall',
      interests: 'indigo, orange, blue, red',
      lastName: 'Burke',
      photo: 'https://randomuser.me/api/portraits/men/1.jpg',
      state: 'Kentucky',
      streetAddress: 'Ap #643-3424 Mattis. Street',
      zip: '58791'
    },
    {
      age: 46,
      city: 'Grand Rapids',
      email: 'ac.urna@Donecnibhenim.org',
      firstName: 'Addison',
      interests: 'blue, indigo, yellow',
      lastName: 'Harding',
      photo: 'https://randomuser.me/api/portraits/men/2.jpg',
      state: 'Michigan',
      streetAddress: '859-8038 Accumsan St.',
      zip: '52558'
    },
    {
      age: 50,
      city: 'Oklahoma city',
      email: 'aliquet.molestie@Loremipsumdolor.edu',
      firstName: 'Xander',
      interests: 'red, violet, yellow, orange, blue',
      lastName: 'Branch',
      photo: 'https://randomuser.me/api/portraits/men/3.jpg',
      state: 'OK',
      streetAddress: '4675 Elit Avenue',
      zip: '22433'
    },
    {
      age: 55,
      city: 'Racine',
      email: 'at.lacus@Aliquamvulputate.co.uk',
      firstName: 'Aquila',
      interests: '',
      lastName: 'Mccarthy',
      photo: 'https://randomuser.me/api/portraits/men/4.jpg',
      state: 'Wisconsin',
      streetAddress: 'P.O. Box 709, 1565 Consequat Rd.',
      zip: '64296'
    }
  ]
