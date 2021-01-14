using CourseDomain;
using CourseDomain.ResourceParamerters;
using System.Collections.Generic;

namespace CourseData.Infrastructures.Services
{
    public interface IStudentRespository
    {
        void Add(Student item);
        void Delete(Student student);
        bool Exist(int id);
        List<Student> Get(bool ordered = true);
        Student Get(int id);
        List<Student> Get(int pageSize, int pageNumber, bool ordered = true);
        List<Student> Get(StudentResourceParamerter param);
        bool Save();
        void Update(Student item);
    }
}