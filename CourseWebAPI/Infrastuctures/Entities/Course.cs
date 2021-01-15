using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Course
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CourseCredit { get; set; }
        public int DepartmentID { get; set; }
        public IList<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
        public IList<CourseAssignment> CourseAssignments { get; set; } = new List<CourseAssignment>();
    }
}
