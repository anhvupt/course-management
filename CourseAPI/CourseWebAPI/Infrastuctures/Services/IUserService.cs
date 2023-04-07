using CourseWebAPI.Infrastuctures.Models;
using System.Threading.Tasks;

namespace CourseWebAPI.Infrastuctures.Services
{
    public interface IUserService
    {
        Task<UserResponseModel> Login(UserRequestModel request);
    }
}