using CourseWebAPI.Infrastuctures.Models;
using CourseWebAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseWebAPI.Services
{
    public interface IInstructorService
    {
        Task Create(InstructorModel model);
        Task Delete(int instructorId);
        Task Edit(int instructorId, InstructorModel model);
        Task<InstructorListModel> Get(int instructorId);
        Task<List<InstructorListModel>> GetList();
    }
}