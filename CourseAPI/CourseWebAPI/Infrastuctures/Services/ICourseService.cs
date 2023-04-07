using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface ICourseService
    {
        Task<List<CourseListModel>> GetList();
        Task<List<CourseListModel>> GetTaughtCourses(int instructorId);
    }
}