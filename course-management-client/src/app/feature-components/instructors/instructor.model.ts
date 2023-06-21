export interface IInstructorParams {}

export interface IInstructorList {
  id: number;
  lastName: string;
  firstMidName: string;
  hireDate: string;
  departments: string[];
  officeLocation: string;
  courses: string[];
}

export interface IInstructor {
  id: number;
  lastName: string;
  firstMidName: string;
  hireDate: string;
  officeLocation: string;
}
