using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IStudentService
    {
        Task<bool> Add(StudentForManipulationDto item);
        Task<bool> Delete(int id);
        Task<StudentDto> GetStudent(int id);
        Task<IEnumerable<StudentDto>> GetStudents(StudentQueryParamerter param);
        bool IsExist(params int[] ids);
        Task<bool> Update(int studentId, StudentForManipulationDto item);
    }
}