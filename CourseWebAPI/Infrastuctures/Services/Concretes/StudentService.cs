using AutoMapper;
using CourseWebAPI.Data;
using CourseWebAPI.Entities;
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

        public async Task<bool> Add(StudentForManipulationDto item)
        {
            var newStudent = _mapper.Map<Student>(item);
            _context.Students.Add(newStudent);
            var totalChanges = await _context.SaveChangesAsync();
            return totalChanges > 0;
        }

        public async Task<bool> Update(int studentId, StudentForManipulationDto item)
        {
            var studentToUpdate = _mapper.Map<Student>(item);
            Student itemInDB = _context.Students.Find(studentId);
            itemInDB.LastName = studentToUpdate.LastName;
            itemInDB.FirstMidName = studentToUpdate.FirstMidName;
            itemInDB.EnrollmentDate = studentToUpdate.EnrollmentDate;
            var totalChanges = await _context.SaveChangesAsync();
            return totalChanges > 0;
        }

        public async Task<IEnumerable<StudentDto>> GetStudents(
            StudentQueryParamerter param)
        {
            var studentInDB = _context.Students.AsNoTracking();

            if (param != null)
            {
                if (!string.IsNullOrWhiteSpace(param.SearchQuery))
                    studentInDB = GetStudentsByName(studentInDB, param.SearchQuery);

                if (param.PageIndex > 0 && param.PageSize > 0)
                    studentInDB = GetPagingStudents(studentInDB,
                        param.PageIndex, param.PageSize);

                if (!string.IsNullOrWhiteSpace(param.OrderBy))
                    studentInDB = GetOrderedStudents(studentInDB, param.OrderBy);
            }

            List<Student> studentCollection = await studentInDB.ToListAsync();
            return _mapper.Map<List<StudentDto>>(studentCollection);

            IQueryable<Student> GetPagingStudents(IQueryable<Student> collection,
                int pageIndex, int pageSize)
            {
                int previous = (pageIndex == 1) ? 0 :
                pageSize * (pageIndex - 1);
                return studentInDB.Skip(previous).Take(pageSize);
            }
            IQueryable<Student> GetStudentsByName(IQueryable<Student> collection,
                string name)
            {
                return studentInDB.Where(i => i.FirstMidName.Contains(name)
                                            || i.LastName.Contains(name));
            }
            IQueryable<Student> GetOrderedStudents(IQueryable<Student> collection,
                string orderBy)
            {
                switch (orderBy.ToLower())
                {
                    case "date-desc":
                        return collection.OrderByDescending(x => x.EnrollmentDate);
                    case "date":
                        return collection.OrderBy(x => x.EnrollmentDate);
                    case "name-desc":
                        return collection.OrderByDescending(x => x.LastName);
                    case "name":
                        return collection.OrderBy(x => x.LastName);
                    default:
                        return collection;
                }
            }
        }

        public async Task<StudentDto> GetStudent(int id)
        {
            if (id <= 0) throw new ArgumentException(nameof(id));
            var studentInDB = await _context.Students.AsNoTracking()
                                    .FirstOrDefaultAsync(i => i.Id == id);
            return _mapper.Map<StudentDto>(studentInDB);
        }

        public async Task<bool> Delete(int id)
        {
            var student = _context.Students.Find(id);
            _context.Students.Remove(student);
            var totalChanges = await _context.SaveChangesAsync();
            return totalChanges > 0;
        }

        public bool IsExist(params int[] ids)
        {
            foreach (int id in ids)
                if (!_context.Students.Any(s => s.Id == id))
                    return false;
            return true;
        }
    }
}
