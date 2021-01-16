using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.Models
{
    
    public class StudentForManipulationDto : PersonForManipulationDto
    {   
        public virtual DateTime EnrollmentDate { get; set; }
    }
}
