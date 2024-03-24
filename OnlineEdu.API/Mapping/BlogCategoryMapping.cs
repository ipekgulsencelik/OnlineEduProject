using AutoMapper;
using OnlineEdu.DTO.DTOs.BlogCategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class BlogCategoryMapping : Profile
    {
        public BlogCategoryMapping()
        {
            CreateMap<CreateBlogCategoryDTO, BlogCategory>().ReverseMap();
            CreateMap<UpdateBlogCategoryDTO, BlogCategory>().ReverseMap();
            CreateMap<ResultBlogCategoryDTO, BlogCategory>().ReverseMap();
        }
    }
}