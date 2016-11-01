import { InMemoryDbService } from 'angular-in-memory-web-api';
import { Hero } from '../models/hero';

export class InMemoryDataService implements InMemoryDbService {
    createDb() {
        let testHero = new Hero();
        testHero.id = 12;
        testHero.name = "Narco";
        testHero.avatar = "hero1.jpg";
        testHero.level = 12;
        testHero.experience = 70;
        testHero.nextLevel = 100;
        testHero.currentHitPoints = 20;
        testHero.maxHitPoints = 30;

        let heroes = [
            {id: 11, name: 'Mr. Nice'},
            testHero,
            {id: 13, name: 'Bombasto'},
            {id: 14, name: 'Celeritas'},
            {id: 15, name: 'Magneta'},
            {id: 16, name: 'RubberMan'},
            {id: 17, name: 'Dynama'},
            {id: 18, name: 'Dr IQ'},
            {id: 19, name: 'Magma'},
            {id: 20, name: 'Tornado'}
        ];

        return {heroes};
    }
}