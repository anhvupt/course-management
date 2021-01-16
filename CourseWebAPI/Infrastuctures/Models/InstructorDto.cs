using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class InstructorDto
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime HireDate { get; set; }
        public List<string> Departments { get; set; } = new List<string>();
        public string Office { get; set; }
        public List<string> Courses {get; set;}
    }
}
