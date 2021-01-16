using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface IEnrollmentService
    {
        Task<bool> CreateEnrollmentsByStudentId(int studentId, params int[] courseIds);
        Task<List<EnrollmentDto>> GetEnrollmentByCourse(int courseId);
    }
}