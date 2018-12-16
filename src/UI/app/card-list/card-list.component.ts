import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-card-list',
  template: `
    <app-card *ngFor="let person of people" [person]="person"></app-card>
    `,
  styleUrls: ['./card-list.component.css']
})
export class CardListComponent implements OnInit {

  @Input() people: any[]
  constructor() {
  }

  ngOnInit() {
  }

}
