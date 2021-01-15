﻿using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.ValidationAttributes
{
    public class StudentNameOnlyContainsLetters : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var student = (StudentForManipulationDto)validationContext.ObjectInstance;

            if (!student.FirstMidName.All(char.IsLetter))
                return new ValidationResult(ErrorMessage,
                    new[] { nameof(StudentForManipulationDto) });

            return ValidationResult.Success;
        }
    }
}
