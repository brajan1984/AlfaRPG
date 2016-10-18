import { Component, OnInit } from "@angular/core";

import { HeroService } from '../services/hero.service';
import { Hero } from '../models/hero';

@Component({
  moduleId: module.Id,
  selector: 'my-heroes',
  templateUrl: 'app/heroes/heroes.component.html',
  styleUrls: [ 'app/app.component.css' ]
})
export class HeroesComponent  implements OnInit {
  
  heroes: Hero[];

  selectedHero: Hero;

  constructor(private heroService: HeroService) {
  }

  ngOnInit(): void {
    this.getHeroes();
  }

  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }

  getHeroes(): void {
    this.heroService.getHeroesSlowly().then(heroes => this.heroes = heroes);
  }
}