using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserEntity>> GetAllUsersAsync(string direction, string orderBy);
        Task<UserEntity> GetOneUserAsync(string userId, bool showUser = false);
        void CreateUser(UserEntity user);
        Task UpdateUserAsync(string userId, UserEntity user);
        Task DeleteUserAsync(string userId);
    }
}