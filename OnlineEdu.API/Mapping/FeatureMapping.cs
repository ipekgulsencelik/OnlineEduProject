using AutoMapper;
using OnlineEdu.DTO.DTOs.FeatureDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<CreateFeatureDTO, Feature>().ReverseMap();
            CreateMap<UpdateFeatureDTO, Feature>().ReverseMap();
            CreateMap<ResultFeatureDTO, Feature>().ReverseMap();
        }
    }
}