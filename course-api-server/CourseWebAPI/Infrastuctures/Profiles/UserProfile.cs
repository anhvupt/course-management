using AutoMapper;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserResponseModel>()
                .ForMember(dest => dest.FirstMidName, opt => opt.MapFrom(src => src.FirstMidName))
                .ForMember(dest => dest.LastName, opt=> opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src=> src.UserName))
                ;
        }
    }
}
