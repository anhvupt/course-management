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
        public CourseAssignmentService(CourseContext context)
        {
            _context = context;
        }

        public async Task AssignCourses(
            int instructorId, params int[] courseIds)
        {
            var courseAssignments = courseIds.Select(id => new CourseAssignment()
            {
                CourseID = id,
                InstructorID = instructorId
            });
            _context.CourseAssignments.AddRange(courseAssignments);
            await _context.SaveChangesAsync();
        }
    }
}
