using appPrevencionRiesgos.Model.Security;
using Microsoft.AspNetCore.Identity;

namespace appPrevencionRiesgos.Services
{
    public interface IMongoDBServices
    {
        Task<List<UserModel>> GetAsync();
         Task CreateAsync(UserModel user);
         Task AddToPlaylistAsync(string id, string movieId);
        Task DeleteAsync(string id);
    }
}
