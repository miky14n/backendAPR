﻿using appPrevencionRiesgos.Data.Entities;
using appPrevencionRiesgos.Model;
using appPrevencionRiesgos.Model.Security;
using AutoMapper;

namespace appPrevencionRiesgos.Data
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<BasicInformationEntity, BasicInformationModel>()
                .ReverseMap();
            this.CreateMap<UserEntity, UserModel>()
                .ReverseMap();
        }
    }
}