using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain
{
    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FistMidName { get; set; }
        public DateTime HireDate { get; set; }
        public List<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }

    }
}
