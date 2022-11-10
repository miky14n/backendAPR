using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public interface IUserInformationRepository
    {
        Task<IEnumerable<UserInformationEntity>> GetAllUsersAsync();
        Task<UserInformationEntity> GetOneUserAsync(string userId);
        Task CreateUser(UserInformationEntity user);
        Task UpdateUserAsync(string userId, UserInformationEntity user);
        Task DeleteUserAsync(string userId);
    }
}