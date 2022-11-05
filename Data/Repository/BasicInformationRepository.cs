using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class BasicInformationRepository : IBasicInformationRepository
    {
        internal MongoDBRepository _mongoRepository = new MongoDBRepository();
        private IMongoCollection<BasicInformationModel> collection;
        public BasicInformationRepository()
        {
            collection = _mongoRepository.dbContext.GetCollection<BasicInformationModel>("BasicInformation");
        }
        public void CreateInformation(BasicInformationEntity basicInformation)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteInformationAsync(int informationId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync(string direction, string orderBy)
        {
            throw new NotImplementedException();
        }

        public async Task<BasicInformationEntity> GetOneInformationAsync(int informationId, bool showInformation = false)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateInformationAsync(int informationId, BasicInformationEntity basicInformation)
        {
            throw new NotImplementedException();
        }
    }
}
