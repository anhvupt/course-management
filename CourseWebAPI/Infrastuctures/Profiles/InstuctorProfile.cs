using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Profiles
{
    public class InstuctorProfile : Profile
    {
        public InstuctorProfile()
        {
            CreateMap<Instructor, InstructorDto>()
                .ForMember(
                    dest => dest.Office,
                    opt => opt.MapFrom(x => x.OfficeAssignment.Location)
                    );
            CreateMap<InstructorForManipulationDto, Instructor>();
            CreateMap<InstructorDto, Instructor>();
        }

    }
}
