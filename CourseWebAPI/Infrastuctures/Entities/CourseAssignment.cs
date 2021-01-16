using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class CourseAssignment
    {
        public virtual int CourseID { get; set; }
        public virtual int InstructorID { get; set; }
        public virtual Course Course {get; set;}
        public virtual Instructor Instructor { get; set; }
    }
}
