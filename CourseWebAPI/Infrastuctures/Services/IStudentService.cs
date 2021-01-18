using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IStudentService
    {
        Task<bool> Create(StudentModel item);
        Task<bool> Delete(int id);
        Task<StudentListModel> Get(int id);
        Task<IEnumerable<StudentListModel>> GetList(StudentQueryParamerter param);
        Task<bool> Update(int studentId, StudentModel item);
    }
}