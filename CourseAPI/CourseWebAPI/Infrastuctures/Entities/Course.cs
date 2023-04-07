using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Course
    {
        public virtual int ID { get; set; }
        public virtual string Title { get; set; }
        public virtual int CourseCredit { get; set; }
        public virtual int DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public virtual IList<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();
        public virtual IList<CourseAssignment> CourseAssignments { get; set; }
            = new List<CourseAssignment>();
    }
}
