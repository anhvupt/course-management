using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
using CourseWebAPI.Infrastuctures.Extensions;
using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public class StudentService : IStudentService
    {
        private readonly CourseContext _context;
        private readonly IMapper _mapper;
        public StudentService(CourseContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task Create(StudentModel model)
        {
            var entity = _mapper.Map<Student>(model);
            _context.Students.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(int studentId, StudentModel model)
        {
            Student entity = _context.Students.Find(studentId);
            _mapper.Map<StudentModel, Student>(model, entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<StudentListModel>> GetList(
            StudentQueryParamerter param)
        {
            int previous = (param.PageIndex == 1) ? 0 : param.PageSize * (param.PageIndex - 1);
            var entities = _context.Students.AsNoTracking()
                .WhereIf(
                    !string.IsNullOrWhiteSpace(param.SearchQuery),
                    (
                        x => x.FirstMidName.Contains(param.SearchQuery) ||
                             x.LastName.Contains(param.SearchQuery)
                    )
                ).Skip(previous).Take(param.PageSize)
                .DynamicSort(param.OrderBy, param.Revert);
            return _mapper.Map<List<StudentListModel>>(await entities.ToListAsync());
        }

        public async Task<StudentListModel> Get(int id)
        {
            var entity = await
                _context.Students.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<StudentListModel>(entity);
        }

        public async Task Delete(int id)
        {
            var student = _context.Students
                .Include(x => x.Enrollments)
                .FirstOrDefault(x => x.Id == id);
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}
