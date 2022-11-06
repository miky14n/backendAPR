using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class BasicInformationRepository : IBasicInformationRepository
    {
        internal MongoDBRepository _mongoRepository = new MongoDBRepository();
        private IMongoCollection<BasicInformationEntity> collection;
        public BasicInformationRepository()
        {
            collection = _mongoRepository.dbContext.GetCollection<BasicInformationEntity>("BasicInformation");
        }
        public void CreateInformation(BasicInformationEntity basicInformation)
        {
            collection.InsertOne(basicInformation);
        }

        public async Task DeleteInformationAsync(string informationId)
        {
            var informationToDelete = Builders<BasicInformationEntity>.Filter.Eq(i => i.Id, new ObjectId(informationId));
            await collection.DeleteOneAsync(informationToDelete);
        }

        public async Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync(string direction, string orderBy)
        {
            return await collection.FindAsync(new BsonDocument()).Result.ToListAsync();
        }

        public async Task<BasicInformationEntity> GetOneInformationAsync(string informationId, bool showInformation = false)
        {
            return await collection.FindAsync(new BsonDocument { { "_id", new ObjectId(informationId) } }).Result.FirstAsync();
        }

        public async Task UpdateInformationAsync(string informationId, BasicInformationEntity basicInformation)
        {
            throw new NotImplementedException();
        }
    }
}
