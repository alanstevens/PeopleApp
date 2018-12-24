import { Component, OnInit } from '@angular/core'
import { PeopleService } from '../shared/people.service'
import { Ng4LoadingSpinnerService } from 'ng4-loading-spinner'

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent implements OnInit {

  people: any[]
  constructor(private peopleService: PeopleService,
    private spinnerService: Ng4LoadingSpinnerService) {
  }

  searchTerm: string

  search() {
    this.spinnerService.show()
    this.peopleService.findPeople(this.searchTerm)
      .subscribe(people => {
        this.people = people
        this.spinnerService.hide()
      })
  }

  ngOnInit() {
  }

}
