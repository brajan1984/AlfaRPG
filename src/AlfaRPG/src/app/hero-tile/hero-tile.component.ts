import { Component, OnInit, Input } from "@angular/core";
import { Hero } from "../models/hero";

@Component({
  moduleId: module.id,
  selector: 'hero-tile',
  templateUrl: 'hero-tile.component.html',
  styleUrls: [ 'hero-tile.component.css' ]
})
export class HeroTileComponent implements OnInit {
    private static avatarsDir: string = "app/resources/images/";

    @Input()
    hero: Hero;

    ngOnInit(){
    }

    private getRatio(num1: number, num2: number): number {
      return Math.round((num1/num2)*100);
    }

    getExperienceRatio(hero: Hero): number {
      return this.getRatio(hero.experience, hero.nextLevel);
    }

    getHealthRatio(hero: Hero): number {
      return this.getRatio(hero.currentHitPoints, hero.maxHitPoints);
    }

    getAvatar(hero: Hero) {
      if(hero.avatar == undefined)
      {
        return HeroTileComponent.avatarsDir + "hero3.jpg";
      }
      else
      {
        return HeroTileComponent.avatarsDir + hero.avatar;
      }
    }
}