import { Component, OnInit } from '@angular/core';
import { PeopleService } from './shared/people.service'

@Component({
  selector: 'app-card-list',
  templateUrl: './card-list.component.html',
  styleUrls: ['./card-list.component.css']
})
export class CardListComponent implements OnInit {

  people: any[]
  constructor(private peopleService: PeopleService) {
  }

  ngOnInit() {
    this.people = this.peopleService.findPeople()
  }

}
