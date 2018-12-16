import { Component, OnInit } from '@angular/core';
import { PeopleService } from '../shared/people.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  people: any[];
  constructor(private peopleService: PeopleService) {
  }

  ngOnInit() {
    this.people = this.peopleService.findPeople();
  }

}
