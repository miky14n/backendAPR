using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        public void CreateUser(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAllUsersAsync(string direction, string orderBy)
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetOneUserAsync(string userId, bool showUser = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserAsync(string userId, UserEntity user)
        {
            throw new NotImplementedException();
        }
    }
}
