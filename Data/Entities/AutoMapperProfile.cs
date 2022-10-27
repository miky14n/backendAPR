using appPrevencionRiesgos.Model;
using AutoMapper;

namespace appPrevencionRiesgos.Data.Entities
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<BasicInformationEntity, BasicInformationModel>()
                .ReverseMap();
        }
    }
}
