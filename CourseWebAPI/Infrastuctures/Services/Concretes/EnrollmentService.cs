using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public class EnrollmentService : IEnrollmentService
    {
        private CourseContext _context;
        private IMapper _mapper;
        public EnrollmentService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<EnrollmentListModel>> GetEnrolledStudents(int courseId)
        {
            var entities = await _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .Where(e => e.CourseID == courseId)
                .ToListAsync();
            return _mapper.Map<List<EnrollmentListModel>>(entities);
        }
        public async Task<bool> EnrollCourses(int studentId,
            params int[] courseIds)
        {
            var enrollments = courseIds.Select(courseId => new Enrollment()
            {
                StudentID = studentId,
                CourseID = courseId,
                Grade = EnrollmentGrade.None
            });
            _context.Enrollments.AddRange(enrollments);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
