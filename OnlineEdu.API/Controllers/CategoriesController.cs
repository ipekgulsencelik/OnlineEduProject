using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.CategoryDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IGenericService<Category> _categoryService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _categoryService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Kurs Kategori Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateCategoryDTO createCategoryDTO)
        {
            var newValue = _mapper.Map<Category>(createCategoryDTO);
            _categoryService.TCreate(newValue);
            return Ok("Yeni Kurs Kategori Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateCategoryDTO updateCategoryDTO)
        {
            var value = _mapper.Map<Category>(updateCategoryDTO);
            _categoryService.TUpdate(value);
            return Ok("Kurs Kategori Alanı Güncellendi");
        }
    }
}