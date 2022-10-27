using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace appPrevencionRiesgos.Data.Repository
{
    public class BasicInformationRepository : IBasicInformationRepository
    {
        private readonly IMongoCollection<BasicInformationEntity> _informationCollection;
        public BasicInformationRepository(IMongoCollection<BasicInformationEntity> informationCollection)
        {
            _informationCollection = informationCollection;
        }
        public void CreateInformation(BasicInformationEntity basicInformation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteInformationAsync(int informationId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync(string direction, string orderBy)
        {
            throw new NotImplementedException();
        }

        public Task<BasicInformationEntity> GetOneInformationAsync(int informationId, bool showInformation = false)
        {
            throw new NotImplementedException();
        }

        public Task UpdateInformationAsync(int informationId, BasicInformationEntity basicInformation)
        {
            throw new NotImplementedException();
        }
    }
}
