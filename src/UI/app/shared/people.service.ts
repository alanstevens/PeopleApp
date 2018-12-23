import { Injectable } from '@angular/core'
import { HttpClient } from '@angular/common/http'
import { Observable, of } from 'rxjs'
import { Person } from '../shared/person'

@Injectable()
export class PeopleService {

  constructor(private http: HttpClient) { }

    private apiUrl = 'http://localhost:5000/api/people/search?searchTerm='

    findPeople(searchTerm: string): Observable<Person[]> {
      return this.http.get<Person[]>(this.apiUrl + searchTerm )
    }
}
