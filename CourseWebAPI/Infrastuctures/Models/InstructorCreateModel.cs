using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class InstructorCreateModel : InstructorModel 
    {
        public override DateTime HireDate { get; set; } = DateTime.Now;
    }
}
