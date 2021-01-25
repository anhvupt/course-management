using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWebAPI.Models
{
    public class StudentListModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string EnrollmentDuration { get; set; }
    }
}
