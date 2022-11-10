using appPrevencionRiesgos.Data.Entities;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class UserRepository : IUserRepository
    {
        internal MongoDbContext _mongoRepository = new MongoDbContext();
        private IMongoCollection<UserEntity> collection;
        public UserRepository()
        {
            collection = _mongoRepository.dbContext.GetCollection<UserEntity>("User");
        }
        public void CreateUser(UserEntity user)
        {
            collection.InsertOne(user);
        }

        public async Task DeleteUserAsync(string userId)
        {
            var userToDelete = Builders<UserEntity>.Filter.Eq(i => i.Id, new ObjectId(userId));
            await collection.DeleteOneAsync(userToDelete);
        }

        public async Task<IEnumerable<UserEntity>> GetAllUsersAsync()
        {
            return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<UserEntity> GetOneUserAsync(string userId)
        {
            return await collection.FindAsync(new BsonDocument { { "_id", new ObjectId(userId) } }).Result.FirstAsync();
        }

        public async Task UpdateUserAsync(string userId, UserEntity user)
        {
            var userToUpdate = Builders<UserEntity>.Filter.Eq(i => i.Id, user.Id);
            await collection.ReplaceOneAsync(userToUpdate, user);
        }
    }
}
