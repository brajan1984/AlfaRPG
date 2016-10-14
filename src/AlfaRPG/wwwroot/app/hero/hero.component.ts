import {Component} from '@angular/core'

@Component({
  moduleId: module.id,
  templateUrl: 'hero.component.html'
})

export class HeroComponent {
    name: string;

  constructor () {
    this.name = 'HeroComponent';
  }
}
