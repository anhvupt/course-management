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
            CreateMap<Instructor, InstructorListModel>()
                .ForMember(
                    dest => dest.OfficeLocation,
                    opt => opt.MapFrom(x => x.OfficeAssignment.Location)
                    )
                .ForMember(
                    dest => dest.Departments,
                    opt => opt.MapFrom(x => x.Departments.Select(d=>d.Name))
                );
            CreateMap<InstructorCreateModel, Instructor>()
                .ForMember(
                    dest => dest.OfficeAssignment,
                    opt =>
                    {
                        opt.Condition(x => !string.IsNullOrWhiteSpace(x.OfficeLocation));
                        opt.MapFrom(x => new OfficeAssignment()
                        {
                            Location = x.OfficeLocation
                        });
                    }
                );
            CreateMap<InstructorEditModel, Instructor>()
                .ForMember(
                    dest => dest.OfficeAssignment,
                    opt =>
                    {
                        opt.MapFrom(x => string.IsNullOrWhiteSpace(x.OfficeLocation) ?
                        null : new OfficeAssignment()
                        {
                            Location = x.OfficeLocation
                        });
                    });
        }

    }
}
