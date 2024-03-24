using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.FeatureDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturesController(IGenericService<Feature> _featureService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _featureService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _featureService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _featureService.TDelete(id);
            return Ok("Öne Çıkan Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateFeatureDTO createFeatureDTO)
        {
            var newValue = _mapper.Map<Feature>(createFeatureDTO);
            _featureService.TCreate(newValue);
            return Ok("Yeni Öne Çıkan Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateFeatureDTO updateFeatureDTO)
        {
            var value = _mapper.Map<Feature>(updateFeatureDTO);
            _featureService.TUpdate(value);
            return Ok("Öne Çıkan Alanı Güncellendi");
        }
    }
}