import { BrowserModule } from '@angular/platform-browser'
import { NgModule } from '@angular/core'

import { AppComponent } from './app.component'
import { CardComponent } from './card/card.component'
import { CardListComponent } from './card-list/card-list.component'
import { SearchComponent } from './search/search.component'
import { PeopleService } from './shared/people.service'
import { HttpClientModule } from '@angular/common/http'
import { InterestComponent } from './interest/interest.component'
import { FormsModule } from '@angular/forms'

@NgModule({
  declarations: [
    AppComponent,
    CardComponent,
    CardListComponent,
    SearchComponent,
    InterestComponent  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    PeopleService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
