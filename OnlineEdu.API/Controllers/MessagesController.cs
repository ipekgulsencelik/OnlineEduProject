using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.MessageDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController(IGenericService<Message> _messageService, IMapper _mapper) : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var values = _messageService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _messageService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _messageService.TDelete(id);
            return Ok("Mesaj Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateMessageDTO createMessageDTO)
        {
            var newValue = _mapper.Map<Message>(createMessageDTO);
            _messageService.TCreate(newValue);
            return Ok("Yeni Mesaj Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateMessageDTO updateMessageDTO)
        {
            var value = _mapper.Map<Message>(updateMessageDTO);
            _messageService.TUpdate(value);
            return Ok("Mesaj Güncellendi");
        }
    }
}