using appPrevencionRiesgos.Data.Repository;
using appPrevencionRiesgos.Model;
using AutoMapper;

namespace appPrevencionRiesgos.Services
{
    public class BasicInformationService : IBasicInformationService
    {
        private IBasicInformationRepository _informationRepository;
        private IMapper _mapper;
        public BasicInformationService(IBasicInformationRepository informationRepository, IMapper mapper)
        {
            _informationRepository = informationRepository;
            _mapper = mapper;
        }

        public void CreateInformation(BasicInformationModel basicInformation)
        {
            var informationEntity = _mapper.Map<FilmFranchiseEntity>(filmFranchise);
            _franchiseRepository.CreateFranchise(informationEntity);
            var result = await _franchiseRepository.SaveChangesAsync();
            if (result)
            {
                return _mapper.Map<FilmFranchiseModel>(informationEntity);
            }
            throw new Exception("Database Error.");
        }

        public Task DeleteInformationAsync(string informationId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BasicInformationModel>> GetAllInformationAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BasicInformationModel> GetOneInformationAsync(string informationId)
        {
            throw new NotImplementedException();
        }

        public Task<BasicInformationModel> UpdateInformationAsync(string informationId, BasicInformationModel basicInformation)
        {
            throw new NotImplementedException();
        }
    }
}
