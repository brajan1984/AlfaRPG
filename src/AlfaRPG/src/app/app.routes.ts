import { provideRouter, RouterConfig } from '@angular/router';

import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { HeroComponent } from './hero/hero.component';

const routes: RouterConfig = [
    { path: '', component: HomeComponent },
    { path: 'about', component: AboutComponent },
    { path: 'hero', component: HeroComponent }
];

export const APP_ROUTER_PROVIDERS = [
    provideRouter(routes)
];