using appPrevencionRiesgos.Data.Entities;
using MongoDB.Bson;
using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class BasicInformationRepository : IUserInformationRepository
    {
        internal MongoDbContext _dbContext = new MongoDbContext();
        private IMongoCollection<BasicInformationEntity> collection;

        public BasicInformationRepository()
        {
            collection = _dbContext.basicInformationDbContext.GetCollection<BasicInformationEntity>("BasicInformation");
        }

        public async Task CreateInformation(BasicInformationEntity basicInformation)
        {
            await collection.InsertOneAsync(basicInformation);
        }

        public async Task DeleteInformationAsync(string informationId)
        {
            var informationToDelete = Builders<BasicInformationEntity>.Filter.Eq(i => i.Id, new ObjectId(informationId));
            await collection.DeleteOneAsync(informationToDelete);
        }

        public async Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync()
        {
            return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<BasicInformationEntity> GetOneInformationAsync(string informationId)
        {
            return await collection.FindAsync(new BsonDocument { { "_id", new ObjectId(informationId) } }).Result.FirstAsync();
        }

        public async Task UpdateInformationAsync(string informationId, BasicInformationEntity basicInformation)
        {
            var informationToUpdate = Builders<BasicInformationEntity>.Filter.Eq(i => i.Id, basicInformation.Id);
            await collection.ReplaceOneAsync(informationToUpdate, basicInformation);
        }
    }
}
