using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Data.Repository;
using appPrevencionRiesgos.Exceptions;
using appPrevencionRiesgos.Model;
using AutoMapper;
using MongoDB.Bson;

namespace appPrevencionRiesgos.Services
{
    public class BasicInformationService : IBasicInformationService
    {
        private IUserInformationRepository _informationRepository;
        private IMapper _mapper;
        public BasicInformationService(IUserInformationRepository informationRepository, IMapper mapper)
        {
            _informationRepository = informationRepository;
            _mapper = mapper;
        }

        public async Task<BasicInformationModel> CreateInformation(BasicInformationModel basicInformation)
        {
            var informationEntity = _mapper.Map<BasicInformationEntity>(basicInformation);
            await _informationRepository.CreateInformation(informationEntity);
            if (true)
            {
                return _mapper.Map<BasicInformationModel>(informationEntity);
            }
            throw new Exception("Database Error.");
        }

        public async Task DeleteInformationAsync(string informationId)
        {
            var result = await GetOneInformationAsync(informationId);
            await _informationRepository.DeleteInformationAsync(informationId);
            if (result == null)
            {
                throw new Exception("Database Error.");
            }
        }

        public async Task<IEnumerable<BasicInformationModel>> GetAllInformationAsync()
        {
            var informationEntityList = await _informationRepository.GetAllInformationAsync();
            return _mapper.Map<IEnumerable<BasicInformationModel>>(informationEntityList);
        }

        public async Task<BasicInformationModel> GetOneInformationAsync(string informationId)
        {
            var information = await _informationRepository.GetOneInformationAsync(informationId);

            if (information == null)
                throw new NotFoundElementException($"Information with id:{informationId} does not exists.");

            return _mapper.Map<BasicInformationModel>(information);
        }

        public async Task<BasicInformationModel> UpdateInformationAsync(string informationId, BasicInformationModel basicInformation)
        {
            var result = await GetOneInformationAsync(informationId);
            var informationEntity = _mapper.Map<BasicInformationEntity>(basicInformation);
            informationEntity.Id = new ObjectId(informationId);

            await _informationRepository.UpdateInformationAsync(informationId, informationEntity);

            if (result != null)
            {
                return _mapper.Map<BasicInformationModel>(informationEntity);
            }

            throw new Exception("Database Error.");
        }
    }
}
