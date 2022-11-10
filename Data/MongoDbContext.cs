using MongoDB.Driver;

namespace appPrevencionRiesgos.Data
{
    public class MongoDbContext
    {
        public MongoClient client;
        public IMongoDatabase dbContext;

        public MongoDbContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            dbContext = client.GetDatabase("BasicInformation");
        }
    }
}