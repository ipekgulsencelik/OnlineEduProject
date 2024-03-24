using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.Business.Abstract;
using OnlineEdu.DTO.DTOs.ContactDTOs;
using OnlineEdu.Entity.Entities;

namespace OnlineEdu.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController(IGenericService<Contact> _contactService, IMapper _mapper) : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            var values = _contactService.TGetList();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            var value = _contactService.TGetByID(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.TDelete(id);
            return Ok("İletişim Alanı Silindi");
        }

        [HttpPost]
        public IActionResult Create(CreateContactDTO createContactDTO)
        {
            var newValue = _mapper.Map<Contact>(createContactDTO);
            _contactService.TCreate(newValue);
            return Ok("Yeni İletişim Alanı Oluşturuldu");
        }

        [HttpPut]
        public IActionResult Update(UpdateContactDTO updateContactDTO)
        {
            var value = _mapper.Map<Contact>(updateContactDTO);
            _contactService.TUpdate(value);
            return Ok("İletişim Alanı Güncellendi");
        }
    }
}