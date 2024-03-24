using AutoMapper;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Mapping
{
    public class CourseMapping : Profile
    {
        public CourseMapping()
        {
            CreateMap<CreateCourseDTO, Course>().ReverseMap();
            CreateMap<UpdateCourseDTO, Course>().ReverseMap();
            CreateMap<ResultCourseDTO, Course>().ReverseMap();
        }
    }
}