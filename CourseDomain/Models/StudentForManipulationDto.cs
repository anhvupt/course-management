using System;
using System.Collections.Generic;
using System.Text;

namespace CourseDomain.Models
{
    public class StudentForManipulationDto
    {
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public IList<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
