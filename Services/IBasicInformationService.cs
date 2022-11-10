using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;

namespace appPrevencionRiesgos.Services
{
    public interface IBasicInformationService
    {
        Task<IEnumerable<BasicInformationModel>> GetAllInformationAsync();
        Task<BasicInformationModel> GetOneInformationAsync(string informationId);
        Task<BasicInformationModel> CreateInformation(BasicInformationModel basicInformation);
        Task<BasicInformationModel> UpdateInformationAsync(string informationId, BasicInformationModel basicInformation);
        Task DeleteInformationAsync(string informationId);
    }
}