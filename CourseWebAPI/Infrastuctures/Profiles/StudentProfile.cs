using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Extensions;
using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<Student, StudentListModel>()
                .ForMember(
                    dest => dest.Name,
                    opt => opt.MapFrom(scr => $"{scr.FirstMidName} {scr.LastName}")
                )
                .ForMember(
                    dest => dest.EnrollmentDuration,
                    opt => opt.MapFrom(scr => scr.EnrollmentDate.GetDurationToNow())
                )
                ;
            CreateMap<StudentModel, Student>();
        }
    }
}
