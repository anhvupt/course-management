using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Models
{
    public class InstructorModel 
    {
        [Required]
        [MaxLength(50)]
        public virtual string LastName { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string FirstMidName { get; set; }
        public virtual DateTime HireDate { get; set; }
        public virtual string OfficeLocation {get; set;}
    }
}
