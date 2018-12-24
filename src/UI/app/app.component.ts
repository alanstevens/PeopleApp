import { Component, OnInit } from '@angular/core'

@Component({
  selector: 'app-root',
  template: `
      <app-search></app-search>
      <ng4-loading-spinner [threshold]="0"></ng4-loading-spinner>
    `,
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PeopleApp'
}
