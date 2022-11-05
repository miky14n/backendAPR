using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class MongoDBRepository
    {
        public MongoClient client;
        public IMongoDatabase dbContext;

        public MongoDBRepository()
        {
            client = new MongoClient("mongodb://localhost:27017");
            dbContext = client.GetDatabase("BasicInformation");
        }
    }
}
