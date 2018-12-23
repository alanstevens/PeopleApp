import { Component, OnInit } from '@angular/core'
import { PeopleService } from '../shared/people.service'

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  people: any[]
  constructor(private peopleService: PeopleService) {
  }

  searchTerm: string

  search() {
    this.peopleService.findPeople(this.searchTerm)
      .subscribe(people => this.people = people)
  }

  ngOnInit() {
  }

}
