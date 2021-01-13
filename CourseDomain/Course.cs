﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CourseCredit { get; set; }
        public int DepartmentID { get; set; }
        public virtual IList<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public virtual List<CourseAssignment> CourseAssignments { get; set; }
    }
}
