using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public interface IBasicInformationRepository
    {
        Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync(string direction, string orderBy);
        Task<BasicInformationEntity> GetOneInformationAsync(int informationId, bool showInformation = false);
        void CreateInformation(BasicInformationEntity basicInformation);
        Task UpdateInformationAsync(int informationId, BasicInformationEntity basicInformation);
        Task DeleteInformationAsync(int informationId);
    }
}
