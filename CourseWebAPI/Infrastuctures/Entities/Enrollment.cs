using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.Entities
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        [Required]
        public EnrollmentGrade Grade {get; set;}
        
    }
}
