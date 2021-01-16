using AutoMapper;
using CourseWebAPI.Data;
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

        public async Task<List<EnrollmentDto>> GetEnrollmentByCourse(int courseId)
        {
            var enrollmentInDb = await _context.Enrollments
                .Include(e => e.Course)
                .Include(e => e.Student)
                .Where(e => e.CourseID == courseId)
                .ToListAsync();
            return _mapper.Map<List<EnrollmentDto>>(enrollmentInDb);
        }
        public async Task<bool> CreateEnrollmentsByStudentId(int studentId,
            params int[] courseIds)
        {
            return false;
        }
    }
}
