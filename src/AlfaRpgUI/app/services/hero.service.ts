import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

import { Hero } from '../models/hero';

import 'rxjs/add/operator/toPromise';

@Injectable()
export class HeroService {
    private heroesUrl = 'app/heroes';

    constructor(private http: Http) {

    }

    getHeroes(): Promise<Hero[]> {
        return this.http.get(this.heroesUrl)
            .toPromise()
            .then(response => response.json().data as Hero[])
            .catch(this.handleError);
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); // for demo purposes only
        return Promise.reject(error.message || error);
    }

    getHeroesAsync(): Promise<Hero[]> {
        return this.getHeroes()
    }

    getHeroesSlowly(): Promise<Hero[]> {
        return new Promise<Hero[]>(resolve =>
                setTimeout(resolve, 2000))
                .then(() => this.getHeroes());
    }

    getHero(id: number): Promise<Hero> {
        return this.getHeroesAsync()
                    .then(heroes => heroes.find(hero => hero.id === id));
        }
}