﻿using appPrevencionRiesgos.Data.Entities;

namespace appPrevencionRiesgos.Data.Repository
{
    public interface IBasicInformationRepository
    {
        Task<IEnumerable<BasicInformationEntity>> GetAllInformationAsync();
        Task<BasicInformationEntity> GetOneInformationAsync(string informationId, bool showInformation = false);
        void CreateInformation(BasicInformationEntity basicInformation);
        Task UpdateInformationAsync(string informationId, BasicInformationEntity basicInformation);
        Task DeleteInformationAsync(string informationId);
    }
}