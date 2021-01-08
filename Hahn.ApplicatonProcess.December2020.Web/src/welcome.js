var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { computedFrom } from 'aurelia-framework';
var Welcome = (function () {
    function Welcome() {
        this.heading = 'Welcome to the Aurelia Navigation App!';
        this.firstName = 'John';
        this.lastName = 'Doe';
        this.previousValue = this.fullName;
    }
    Object.defineProperty(Welcome.prototype, "fullName", {
        get: function () {
            return this.firstName + " " + this.lastName;
        },
        enumerable: false,
        configurable: true
    });
    Welcome.prototype.submit = function () {
        this.previousValue = this.fullName;
        alert("Welcome, " + this.fullName + "!");
    };
    Welcome.prototype.canDeactivate = function () {
        if (this.fullName !== this.previousValue) {
            return confirm('Are you sure you want to leave?');
        }
    };
    __decorate([
        computedFrom('firstName', 'lastName'),
        __metadata("design:type", String),
        __metadata("design:paramtypes", [])
    ], Welcome.prototype, "fullName", null);
    return Welcome;
}());
export { Welcome };
var UpperValueConverter = (function () {
    function UpperValueConverter() {
    }
    UpperValueConverter.prototype.toView = function (value) {
        return value && value.toUpperCase();
    };
    return UpperValueConverter;
}());
export { UpperValueConverter };
//# sourceMappingURL=welcome.js.map