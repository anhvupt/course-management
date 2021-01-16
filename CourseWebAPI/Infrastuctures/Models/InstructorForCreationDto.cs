using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    public class InstructorForCreationDto : InstructorForManipulationDto 
    {
        public override DateTime HireDate { get; set; } = DateTime.Now;
    }
}
