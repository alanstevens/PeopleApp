import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-interest',
  template: `
        <span class="badge badge-secondary">{{interest.name}}</span>
`,
  styleUrls: ['./interest.component.css']
})
export class InterestComponent implements OnInit {

  @Input() interest: any
  constructor() { }

  ngOnInit() {
  }

}
