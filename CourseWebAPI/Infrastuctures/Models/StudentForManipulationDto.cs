using CourseWebAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CourseWebAPI.Models
{
    [StudentNameOnlyContainsLetters (
        ErrorMessage = "Both FirstMidName and LastName must only contain letters")]
    public class StudentForManipulationDto
    {
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(500)]
        public string FirstMidName { get; set; }
        public virtual DateTime EnrollmentDate { get; set; }
    }
}
