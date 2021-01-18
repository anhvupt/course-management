using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.Models
{
    
    public class StudentModel
    {
        [Required]
        [MaxLength(50)]
        public virtual string LastName { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string FirstMidName { get; set; }
        public virtual DateTime EnrollmentDate { get; set; }
    }
}
