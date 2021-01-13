using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain
{
    public enum EnrollmentGrade
    {
        None,
        A,
        B, 
        C,
        D, 
        E
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public EnrollmentGrade Grade {get; set;}
        
    }
}
