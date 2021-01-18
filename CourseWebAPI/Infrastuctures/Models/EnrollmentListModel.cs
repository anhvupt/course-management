using CourseWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class EnrollmentListModel
    {
        public string Student { get; set; }
        public string Course { get; set; }
        public EnrollmentGrade Grade { get; set; }
    }
}
