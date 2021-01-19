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
                ).ForMember(
                    dest => dest.Departments,
                    opt => opt.MapFrom(x => x.Departments.Select(d=>d.Name))
                ).ForMember(
                    dest => dest.Courses,
                    opt => opt.MapFrom(x => x.CourseAssignments.Select(d=>d.Course.Title))
                )
                ;
            CreateMap<InstructorModel, Instructor>()
                .ForMember(
                    dest => dest.OfficeAssignment,
                    opt =>
                    {
                        opt.MapFrom(x => string.IsNullOrWhiteSpace(x.OfficeLocation) ?
                        null : new OfficeAssignment()
                        {
                            Location = x.OfficeLocation
                        });
                    }
                ).ForMember(
                    dest => dest.HireDate,
                    opt => opt.MapFrom(x => (x.Id > 0) ? x.HireDate : DateTime.Now)
                )
                ;
        }

    }
}
