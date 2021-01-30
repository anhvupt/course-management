import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from "@angular/router";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";
import { StudentsService } from "src/app/feature-components/students/students.service";
import { StudentResolved } from "./student-shared";



@Injectable({
    providedIn: 'root'
})
export class StudentsResolver implements Resolve<StudentResolved>{

    constructor (private studentService: StudentsService){}
    
    resolve(route : ActivatedRouteSnapshot, 
            state: RouterStateSnapshot) : Observable<StudentResolved>{

        const id = route.paramMap.get('id');
        if(isNaN(+id)) {
            const message = `Student id is not a number: ${id}`
            console.error(message)
            return of ({student: null, error: message})
        }
        this.studentService.updateStudentId(+id)
    }
}
