using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Student
    {
        public virtual int Id { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstMidName { get; set; }
        public virtual DateTime EnrollmentDate { get; set; }
        public virtual IList<Enrollment> Enrollments { get; set; } 
            = new List<Enrollment>();
    }
}
