using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public class BasicInformationRepository : IBasicInformationRepository
    {
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
