using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.SubscriberDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribersController(IGenericService<Subscriber> _subscriberService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _subscriberService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _subscriberService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _subscriberService.TDelete(id);
            return Ok("Abone Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateSubscriberDTO createSubscriberDTO)
        {
            var newValue = _mapper.Map<Subscriber>(createSubscriberDTO);
            _subscriberService.TCreate(newValue);
            return Ok("Yeni Abone Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateSubscriberDTO updateSubscriberDTO)
        {
            var value = _mapper.Map<Subscriber>(updateSubscriberDTO);
            _subscriberService.TUpdate(value);
            return Ok("Abone Güncellendi");
        }
    }
}