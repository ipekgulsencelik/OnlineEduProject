using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CourseDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController(IGenericService<Course> _courseService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _courseService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]

        public IActionResult GetByID(int id)
        {
            var value = _courseService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.TDelete(id);
            return Ok("Kurs Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateCourseDTO createCourseDTO)
        {
            var newValue = _mapper.Map<Course>(createCourseDTO);
            _courseService.TCreate(newValue);
            return Ok("Yeni Kurs Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCourseDTO updateCourseDTO)
        {
            var value = _mapper.Map<Course>(updateCourseDTO);
            _courseService.TUpdate(value);
            return Ok("Kurs Alanı Güncellendi");
        }
    }
}