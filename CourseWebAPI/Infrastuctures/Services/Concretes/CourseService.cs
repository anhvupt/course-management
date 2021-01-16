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
    public class CourseService : ICourseService
    {
        private CourseContext _context;
        private IMapper _mapper;
        public CourseService(CourseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<CourseDto>> GetCourses()
        {
            var coursesInDb = await
                _context.Courses.Include(c => c.Department).ToListAsync();
            return _mapper.Map<List<CourseDto>>(coursesInDb);
        }

        public async Task<List<CourseDto>> GetCoursesByInstructor(int instructorId)
        {
            List<CourseDto> result = new List<CourseDto>();
            var instructorInDb = await _context.Instructors
                .Include(i => i.CourseAssignments)
                .FirstOrDefaultAsync(i => i.ID == instructorId);

            foreach (var ca in instructorInDb.CourseAssignments)
            {
                await _context.Entry(ca).Reference(ca => ca.Course).LoadAsync();
                result.Add(_mapper.Map<CourseDto>(ca.Course));
            }
            return result;
        }

        public bool IsExist(params int[] ids)
        {
            foreach (var id in ids)
                if (!_context.Courses.Any(c => c.ID == id))
                    return false;
            return true;
        }
    }
}
