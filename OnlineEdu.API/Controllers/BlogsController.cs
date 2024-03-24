using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.BlogDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController(IGenericService<Blog> _blogService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _blogService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _blogService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _blogService.TDelete(id);
            return Ok("Blog Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateBlogDTO createBlogDTO)
        {
            var newValue = _mapper.Map<Blog>(createBlogDTO);
            _blogService.TCreate(newValue);
            return Ok("Yeni Blog Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateBlogDTO updateBlogDTO)
        {
            var value = _mapper.Map<Blog>(updateBlogDTO);
            _blogService.TUpdate(value);
            return Ok("Blog Alanı Güncellendi");
        }
    }
}