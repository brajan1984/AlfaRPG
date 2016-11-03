import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { HeroesComponent } from './heroes/heroes.component';
import { HeroDetailComponent } from './hero-detail/hero-detail.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { HeroSearchComponent } from './hero-search/hero-search.component';
import { HeroTileComponent } from './hero-tile/hero-tile.component';
import { HeroService } from './services/hero.service';


import { AppRoutingModule } from './app-routing.module';

// Imports for loading & configuring the in-memory web api
import { InMemoryWebApiModule } from 'angular-in-memory-web-api';
import { InMemoryDataService }  from './services/in-memory-data.service';

//Controls
import { InputTextModule, ProgressBarModule } from 'primeng/primeng';

import './rxjs-extensions';

@NgModule({
    imports: [ 
        BrowserModule,
        FormsModule,
        AppRoutingModule,
        HttpModule,
        InMemoryWebApiModule.forRoot(InMemoryDataService),
        InputTextModule,
        ProgressBarModule
    ],
    declarations: [ 
        AppComponent,
        HeroesComponent,
        HeroDetailComponent,
        DashboardComponent,
        HeroSearchComponent,
        HeroTileComponent
    ],
    providers: [ HeroService ],
    bootstrap: [ AppComponent ]
})
export class AppModule { 

}