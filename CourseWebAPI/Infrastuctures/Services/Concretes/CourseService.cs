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

        public async Task<List<CourselistModel>> GetList()
        {
            var entities = await
                _context.Courses.Include(c => c.Department).ToListAsync();
            return _mapper.Map<List<CourselistModel>>(entities);
        }

        public async Task<List<CourselistModel>> GetTaughtCourses(int instructorId)
        {
            List<CourselistModel> result = new List<CourselistModel>();
            var entities = await _context.Instructors
                .Include(i => i.CourseAssignments)
                .FirstOrDefaultAsync(i => i.ID == instructorId);

            foreach (var ca in entities.CourseAssignments)
            {
                await _context.Entry(ca).Reference(ca => ca.Course).LoadAsync();
                result.Add(_mapper.Map<CourselistModel>(ca.Course));
            }
            return result;
        }
    }
}
