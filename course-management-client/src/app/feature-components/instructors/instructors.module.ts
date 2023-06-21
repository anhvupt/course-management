import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { InstructorsListComponent } from './instructor-list/instructors-list.component';



@NgModule({
    imports: [
        CommonModule,
        RouterModule.forChild([
            { path: 'instructors', component: InstructorsListComponent }
        ]),
        InstructorsListComponent
    ]
})
export class InstructorsModule { }
