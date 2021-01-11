import { Aurelia, PLATFORM } from 'aurelia-framework';
import { Router, RouterConfiguration } from 'aurelia-router';

export class App {
    router: Router;

    configureRouter(config: RouterConfiguration, router: Router) {
        config.title = 'Applicants App';
        config.map([{
            route: ['', 'home'],
            name: 'home',
            settings: { icon: 'home' },
            moduleId: PLATFORM.moduleName('../home/home'),
            nav: false,
            title: 'Home'
        }, {
            route: 'fetch-data',
            name: 'fetchdata',
            settings: { icon: 'th-list' },
            moduleId: PLATFORM.moduleName('../fetchdata/fetchdata'),
            nav: true,
            title: 'Applicant data'
        },
        {
            route: 'insert',
            name: 'insert',
            settings: { icon: 'education' },
            moduleId: PLATFORM.moduleName('../insert/insert'),
            nav: false,
            title: 'Insert data'
        },
        {
            route: 'applicantdetails',
            name: 'applicantdetails',
            settings: { icon: 'education' },
            moduleId: PLATFORM.moduleName('../applicantdetails/applicantdetails'),
            nav: false,
            title: 'Applicant Details '
        }
        ]);

        this.router = router;
    }
}
