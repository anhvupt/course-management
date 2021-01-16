using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface ICourseAssignmentService
    {
        Task<bool> CreateCourseAssignment(int instructorId, params int[] courseIds);
    }
}