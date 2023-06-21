import { NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { IInstructorList } from '../instructor.model';

@Component({
  selector: 'app-instructors-list',
  templateUrl: './instructors-list.component.html',
  styleUrls: ['./instructors-list.component.css'],
  standalone: true,
  imports: [NgFor]
})
export class InstructorsListComponent implements OnInit {
  instructors: IInstructorList[] = [
    {
      id: 1,
      lastName: 'Alexander',
      firstMidName: 'Carson',
      hireDate: '2005-09-01',
      officeLocation: 'Smith 17',
      departments: [],
      courses: []
    },
    {
      id: 2,
      lastName: 'Alonso',
      firstMidName: 'Meredith',
      departments: [],
      hireDate: '2002-09-01',
      officeLocation: 'Smith 17',
      courses: []
    }
  ];
  constructor() {}

  ngOnInit(): void {}
}
