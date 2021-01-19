using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface IEnrollmentService
    {
        Task EnrollCourses(int studentId, params int[] courseIds);
        Task<List<EnrollmentListModel>> GetEnrolledStudents(int courseId);
    }
}