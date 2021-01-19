using CourseWebAPI.Models;
using CourseWebAPI.ResourceParamerters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IStudentService
    {
        Task Create(StudentModel model);
        Task Delete(int id);
        Task<StudentListModel> Get(int id);
        Task<IEnumerable<StudentListModel>> GetList(StudentQueryParamerter param);
        Task Update(int studentId, StudentModel model);
    }
}