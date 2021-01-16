using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Department
    {
        public virtual int DepartmentID { get; set; }
        public virtual string Name { get; set; }
        public virtual double Budget { get;set; }
        public virtual DateTime StartDate { get; set; }
        public virtual int InstructorID { get; set; }
        public virtual Instructor Administator { get; set; }
        public virtual IList<Course> Courses { get; set; } = new List<Course>();

    }
}
