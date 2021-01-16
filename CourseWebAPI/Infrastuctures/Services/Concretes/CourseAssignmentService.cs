using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Infrastuctures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public class CourseAssignmentService : ICourseAssignmentService
    {
        private CourseContext _context;
        private IMapper _mapper;
        public CourseAssignmentService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateCourseAssignment(
            int instructorId, params int[] courseIds)
        {
            return false;
        }
    }
}
