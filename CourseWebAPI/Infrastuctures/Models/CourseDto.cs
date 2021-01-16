using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class CourseDto
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public int CourseCredit { get; set; }
        public string Department { get; set; }
    }
}
