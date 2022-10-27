using appPrevencionRiesgos.Model;
using appPrevencionRiesgos.Model.Security;
using Microsoft.AspNetCore.Identity;

namespace appPrevencionRiesgos.Services
{
    public interface IBasicInformationService
    {
        Task<List<BasicInformationModel>> GetAllBasicInformationAsync();
        Task<BasicInformationModel?> GetOneBasicInformationAsync(int id);
        Task CreateBasicInformationAsync(BasicInformationModel basicInformation);
        Task UpdateBasicInformationAsync(int id, BasicInformationModel basicInformation);
        Task DeleteBasicInformationAsync(int id);
    }
}
