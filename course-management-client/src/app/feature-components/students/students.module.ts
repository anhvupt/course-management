import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { StudentsRoutingModule } from './students-routing.module';


@NgModule({
    imports: [
    FormsModule,
    StudentsRoutingModule,
    StudentsRoutingModule.components
]
})
export class StudentsModule { }
