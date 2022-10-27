using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using AutoMapper;

namespace appPrevencionRiesgos.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<BasicInformationEntity, BasicInformationModel>()
                .ReverseMap();
        }
    }
}
