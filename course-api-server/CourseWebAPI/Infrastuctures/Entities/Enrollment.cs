using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Enrollment
    {
        public virtual int EnrollmentID { get; set; }
        public virtual int CourseID { get; set; }
        public virtual int StudentID { get; set; }
        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        [Required]
        public virtual EnrollmentGrade Grade {get; set;}
        
    }
}
