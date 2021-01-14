using AutoMapper;
using CourseDomain;
using CourseDomain.Models;
using CourseWebAPI.Infrastuctures.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentDto>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(scr => $"{scr.FirstMidName} {scr.LastName}")
                )
                .ForMember(
                    dest => dest.EnrollmentDuration,
                    opt => opt.MapFrom(scr => scr.EnrollmentDate.GetDurationToNow())
                );
            CreateMap<StudentForManipulationDto, Student>();
        }
    }
}
