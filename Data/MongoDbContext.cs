using MongoDB.Driver;

namespace appPrevencionRiesgos.Data
{
    public class MongoDbContext
    {
        public MongoClient client;
        public IMongoDatabase basicInformationDbContext;
        public IMongoDatabase UserDbContext;

        public MongoDbContext()
        {
            client = new MongoClient("mongodb://localhost:27017");
            basicInformationDbContext = client.GetDatabase("BasicInformation");
            UserDbContext = client.GetDatabase("User");
        }
    }
}