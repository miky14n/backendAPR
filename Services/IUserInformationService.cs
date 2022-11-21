using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using appPrevencionRiesgos.Model.Security;

namespace appPrevencionRiesgos.Services
{
    public interface IUserInformationService
    {
        Task<IEnumerable<UserInformationModel>> GetAllUsersAsync();
        Task<UserInformationModel> GetOneUserAsync(string userId);
        Task<UserInformationModel> CreateUser(UserInformationModel userInformation);
        Task<UserInformationModel> UpdateUserAsync(string userId, UserInformationModel userInformation);
        Task DeleteUserAsync(string userId);
    }
}
