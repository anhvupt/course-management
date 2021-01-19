using CourseWebAPI.Entities;
using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class EnrollmentListModel
    {
        public StudentListModel Student { get; set; }
        public CourseListModel Course { get; set; }
        public EnrollmentGrade Grade { get; set; }
    }
}
