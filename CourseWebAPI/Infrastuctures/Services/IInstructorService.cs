using CourseWebAPI.Infrastuctures.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IInstructorService
    {
        Task<bool> Create(InstructorCreateModel instructor);
        Task<bool> Delete(int instructorId);
        Task<InstructorListModel> Get(int instructorId);
        Task<List<InstructorListModel>> GetList();
        Task<bool> Edit(int instructorId, InstructorEditModel instructor);
    }
}