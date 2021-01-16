using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Profiles
{
    public class EnrollmentProfile : Profile
    {
        public EnrollmentProfile()
        {
            CreateMap<Enrollment, EnrollmentDto>()
                .ForMember(
                    dest => dest.Student,
                    opt => opt.MapFrom(e => $"{e.Student.FirstMidName} {e.Student.LastName}")
                )
                .ForMember(
                    dest => dest.Course,
                    opt => opt.MapFrom(e => e.Course.Title)
                )
                .ForMember(
                    dest => dest.Grade,
                    opt => opt.MapFrom(e => e.Grade.ToString())
                );
        }
    }
}
