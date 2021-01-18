using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface ICourseService
    {
        Task<List<CourselistModel>> GetList();
        Task<List<CourselistModel>> GetTaughtCourses(int instructorId);
    }
}