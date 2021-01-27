import { Injectable } from "@angular/core";
import { ActivatedRouteSnapshot, Resolve, RouterStateSnapshot } from "@angular/router";
import { Observable, of } from "rxjs";
import { catchError, map } from "rxjs/operators";
import { StudentService } from "src/app/core/services/student.service";
import { IStudent, StudentResolved } from "src/app/shared/models/student";
import { isCallSignatureDeclaration } from "typescript";



@Injectable({
    providedIn: 'root'
})
export class StudentsResolver implements Resolve<StudentResolved>{

    constructor (private studentService: StudentService){}
    
    resolve(route : ActivatedRouteSnapshot, 
            state: RouterStateSnapshot) : Observable<StudentResolved>{

        const id = route.paramMap.get('id');
        if(isNaN(+id)) {
            const message = `Student id is not a number: ${id}`
            console.error(message)
            return of ({student: null, error: message})
        }
        return this.studentService.getStudent(+id)
        .pipe(
            map(student => ({id: +id, student: student})),
            catchError(err => {
                const message = `Retrieval error: ${err}`
                console.log(err)
                return of ({student: null, error: message})
            })
        )
    }
}
