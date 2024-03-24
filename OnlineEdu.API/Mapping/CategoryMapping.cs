using AutoMapper;
using OnlineEdu.DTO.DTOs.CategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<CreateCategoryDTO, Category>().ReverseMap();
            CreateMap<UpdateCategoryDTO, Category>().ReverseMap();
            CreateMap<ResultCategoryDTO, Category>().ReverseMap();
        }
    }
}