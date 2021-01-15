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
        public int InstructorID { get; set; }
        public Instructor Administator { get; set; }

    }
}
