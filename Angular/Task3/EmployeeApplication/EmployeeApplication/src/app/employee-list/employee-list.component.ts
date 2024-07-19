import { Component } from "@angular/core";

@Component({
    selector:'app-employee-list',
    templateUrl:'./employee-list.component.html',
    styleUrls:['./employee-list.component.css']

})
export class EmployeeListComponent{
    employees=[{firstName:'yashu', lastName:'reddy', gender:'male',salary:4000,country:'USA'},
               {firstName:'lahari',lastName:'guru',gender:'female',salary:8000,country:'UK'},
               {firstName:'sravya',lastName:'bolle',gender:'female',salary:9000,country:'canada'},
               {firstName:'likki',lastName:'madasu',gender:'female',salary:2000,country:'Australia'}
    ];

}
