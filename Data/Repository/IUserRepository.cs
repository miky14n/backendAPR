using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetAllUsersAsync();
        Task<UserEntity> GetOneUserAsync(string userId);
        Task CreateUser(UserEntity user);
        Task UpdateUserAsync(string userId, UserEntity user);
        Task DeleteUserAsync(string userId);
    }
}