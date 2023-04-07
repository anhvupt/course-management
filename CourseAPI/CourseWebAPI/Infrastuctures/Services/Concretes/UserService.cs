using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Extensions;
using CourseWebAPI.Infrastuctures.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public class UserService : IUserService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        public UserService(CourseContext context, IMapper mapper, IConfiguration configuration)
        {
            _context = context;
            _mapper = mapper;
            _config = configuration;
        }
        public async Task<UserResponseModel> Login(UserRequestModel request)
        {
            User entity = _context.Users.FirstOrDefault(user =>
                user.UserName.Equals(request.UserName) && user.Password.Equals(request.Password)
            );
            if (entity == null) return null;
            var model = _mapper.Map<UserResponseModel>(entity);
            model.Token = await Task.Run(() => GenerateToken(entity));
            return model;
        }
        private string GenerateToken(User user)
        {
            var tokenConfig = JwtConfigModel.ReadFrom(_config);
            return new TokenHelper(tokenConfig).GenerateToken(user);
        }
    }
}
