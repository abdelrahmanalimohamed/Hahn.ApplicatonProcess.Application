import { PLATFORM } from 'aurelia-pal';
var App = (function () {
    function App() {
    }
    App.prototype.configureRouter = function (config, router) {
        config.title = 'Aurelia';
        config.map([
            {
                route: ['', 'welcome'],
                name: 'welcome',
                moduleId: PLATFORM.moduleName('./welcome'),
                nav: true,
                title: 'Welcome'
            },
            {
                route: 'users',
                name: 'users',
                moduleId: PLATFORM.moduleName('./users'),
                nav: true,
                title: 'Github Users'
            },
            {
                route: 'child-router',
                name: 'child-router',
                moduleId: PLATFORM.moduleName('./child-router'),
                nav: true,
                title: 'Child Router'
            }
        ]);
        this.router = router;
    };
    return App;
}());
export { App };
//# sourceMappingURL=app.js.map