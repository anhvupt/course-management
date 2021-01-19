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

        public async Task<bool> Create(StudentModel model)
        {
            var entity = _mapper.Map<Student>(model);
            _context.Students.Add(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Update(int studentId, StudentModel model)
        {
            Student entity = _context.Students.Find(studentId);
            _mapper.Map<StudentModel, Student>(model, entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<StudentListModel>> GetList(
            StudentQueryParamerter param)
        {
            int previous = (param.PageIndex == 1) ? 0 :
                            param.PageSize * (param.PageIndex - 1);

            var entities = _context.Students.AsNoTracking()
                .WhereIf(
                    condition: !string.IsNullOrWhiteSpace(param.SearchQuery),
                    (x => x.FirstMidName.Contains(param.SearchQuery) ||
                          x.LastName.Contains(param.SearchQuery))
                ).Skip(previous).Take(param.PageSize)
                .DynamicSort(param.OrderBy, param.Revert);

            //switch (param.OrderBy.ToLower())
            //{
            //    case "date-desc":
            //        entities.OrderByDescending(x => x.EnrollmentDate);
            //        break;
            //    case "date":
            //        entities.OrderBy(x => x.EnrollmentDate);
            //        break;
            //    case "name-desc":
            //        entities.OrderByDescending(x => x.LastName);
            //        break;
            //    default:
            //        entities.OrderBy(x => x.LastName);
            //        break;
            //}

            return _mapper.Map<List<StudentListModel>>(
                await entities.ToListAsync()
                );
        }

        public async Task<StudentListModel> Get(int id)
        {
            var entity = await
                _context.Students.AsNoTracking().FirstOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<StudentListModel>(entity);
        }

        public async Task<bool> Delete(int id)
        {
            var student = _context.Students.Include(x=>x.Enrollments)
                .FirstOrDefault(x=>x.Id == id);
            _context.Students.Remove(student);
            var totalChanges = await _context.SaveChangesAsync();
            return totalChanges > 0;
        }
    }
}
