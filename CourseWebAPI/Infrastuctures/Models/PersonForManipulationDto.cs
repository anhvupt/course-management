using CourseWebAPI.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Models
{
    [NameOnlyContainsLetters(
        ErrorMessage = "Both FirstMidName and LastName must only contain letters")]
    public class PersonForManipulationDto
    {
        [Required]
        [MaxLength(50)]
        public virtual string LastName { get; set; }

        [Required]
        [MaxLength(500)]
        public virtual string FirstMidName { get; set; }
    }
}
