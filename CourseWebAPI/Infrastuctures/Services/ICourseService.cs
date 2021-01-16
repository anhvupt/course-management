using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface ICourseService
    {
        Task<List<CourseDto>> GetCourses();
        Task<List<CourseDto>> GetCoursesByInstructor(int instructorId);
    }
}