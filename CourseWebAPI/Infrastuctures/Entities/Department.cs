using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public double Budget { get;set; }
        public DateTime StartDate { get; set; }
        public int? InstructorID { get; set; }
        public virtual Instructor Administator { get; set; }
        public virtual IList<Course> Courses { get; set; } = new List<Course>();
    }
}
