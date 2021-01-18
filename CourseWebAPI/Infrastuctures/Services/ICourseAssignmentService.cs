using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface ICourseAssignmentService
    {
        Task<bool> AssignCourses(int instructorId, params int[] courseIds);
    }
}