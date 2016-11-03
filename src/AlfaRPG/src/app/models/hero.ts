export class Hero {
  id: number;
  avatar: string;
  name: string;
  level: number = 0;
  experience: number;
  nextLevel: number;
  currentHitPoints: number;
  maxHitPoints: number;
  attack: number;
  armour: number;
  gold: number;

  constructor(){
    this.level = 0;
    this.experience = 0;
  }
}