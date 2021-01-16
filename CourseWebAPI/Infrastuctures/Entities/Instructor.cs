using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Instructor
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }
        public IList<CourseAssignment> CourseAssignments { get; set; } = new List<CourseAssignment>();
        public OfficeAssignment OfficeAssignment { get; set; }

    }
}
