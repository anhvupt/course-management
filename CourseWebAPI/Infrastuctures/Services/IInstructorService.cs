using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IInstructorService
    {
        Task<bool> CreateInstructor(InstructorForCreationDto instructor);
        Task<bool> DeleteInstructor(int instructorId);
        Task<InstructorDto> GetInstructor(int instructorId);
        Task<List<InstructorDto>> GetInstructors();
        Task<bool> UpdateInstructor(int instructorId, InstructorForUpdateDto instructor);
        bool IsExist(params int[] ids);
    }
}