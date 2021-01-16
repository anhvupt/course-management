using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
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
            foreach (var courseId in courseIds)
                _context.CourseAssignments.Add(
                    new CourseAssignment()
                    {
                        CourseID = courseId,
                        InstructorID = instructorId
                    });
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
