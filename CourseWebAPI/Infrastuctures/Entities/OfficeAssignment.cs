using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class OfficeAssignment
    {
        public virtual int InstructorID { get; set; }
        public virtual string Location { get; set; }
        public virtual Instructor Instructor { get; set; }
    }

}
