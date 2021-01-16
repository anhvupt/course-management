using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Instructor
    {
        public virtual int ID { get; set; }
        public virtual string LastName { get; set; }
        public virtual string FirstMidName { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual IList<CourseAssignment> CourseAssignments { get; set; } = new List<CourseAssignment>();
        public virtual OfficeAssignment OfficeAssignment { get; set; }

    }
}
