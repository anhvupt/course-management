using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Models
{
    public class InstructorForManipulationDto : PersonForManipulationDto
    {
        public virtual DateTime HireDate { get; set; }
        public virtual string Office {get; set;}
    }
}
