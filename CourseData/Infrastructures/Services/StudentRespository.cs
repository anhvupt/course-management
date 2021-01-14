using CourseData.Infrastructures.Extentions;
using CourseDomain;
using CourseDomain.ResourceParamerters;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CourseData.Infrastructures.Services
{
    public class StudentRespository : IStudentRespository
    {
        private readonly CourseContext _context;
        public StudentRespository(CourseContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Add(Student item)
        {
            if (item == null) throw new ArgumentNullException(nameof(item));
            _context.Add(item);
        }

        public void Update(Student item)
        {
            if (item == null || item.Id <= 0) throw new ArgumentException(nameof(item));

            Student itemInDB = _context.Students.Find(item.Id);
            itemInDB.LastName = item.LastName;
            itemInDB.FirstMidName = item.FirstMidName;
            itemInDB.EnrollmentDate = item.EnrollmentDate;
        }

        public List<Student> Get(bool ordered = true)
            => (ordered)
            ? GetQueryable().OrderBy(i => i.LastName).ToList()
            : GetQueryable().ToList();

        public List<Student> Get(int pageSize, int pageNumber, bool ordered = true)
        {
            if (!IsValid())
                throw new ArgumentException($"{nameof(pageSize)} and {nameof(pageNumber)}");

            int previous = (pageNumber == 1) ? 0 : pageSize * (pageNumber - 1) - 1;
            IQueryable<Student> rawResult = _context.Students.AsNoTracking()
                .Skip(previous).Take(pageNumber);

            return ordered ?
                rawResult.OrderBy(i => i.LastName).ToList() : rawResult.ToList();

            bool IsValid() => (pageSize > 0 || pageNumber > 0);
        }

        public Student Get(int id)
        {
            if (id <= 0) throw new ArgumentException(nameof(id));
            return _context.Students.AsNoTracking()
                .Include(i => i.Enrollments)
                .FirstOrDefault(i => i.Id == id);
        }

        public List<Student> Get(StudentResourceParamerter param)
        {
            if (param == null) throw new ArgumentNullException(nameof(param));
            if (string.IsNullOrWhiteSpace(param.SearchQuery)) return Get();

            return _context.Students.Where(i =>
               i.FirstMidName.Contains(param.SearchQuery)
               || i.LastName.Contains(param.SearchQuery)
            ).ToList();
        }

        public void Delete(Student student) => _context.Students.Remove(student);

        public bool Exist(int id)
        {
            if (!id.IsValidId()) throw new ArgumentOutOfRangeException();
            return _context.Students.Any(i => i.Id == id);
        }
        private IQueryable<Student> GetQueryable() => _context.Students.AsNoTracking();
        public bool Save() => (_context.SaveChanges() > 0);

    }
}
