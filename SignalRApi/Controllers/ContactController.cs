﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.ContactDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class ContactController : ControllerBase
   {
      private readonly IContactService _contactService;
      private readonly IMapper _mapper;

      public ContactController(IContactService contactService, IMapper mapper)
      {
         _contactService = contactService;
         _mapper = mapper;
      }

      [HttpGet]
      public IActionResult ContactList() 
      {
         var values = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
         return Ok(values);
      }

      [HttpPost]
      public IActionResult CreateContact(CreateContactDto createContactDto)
      {
         _contactService.TAdd(new Contact()
         {
            FooterDescription = createContactDto.FooterDescription,
            Location = createContactDto.Location,
            Mail=createContactDto.Mail,
            Phone=createContactDto.Phone
         });
         return Ok("İletişim bilgileri eklendi");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteContact(int id)
      {
         var values= _contactService.TGetByID(id);
         _contactService.TDelete(values);
         return Ok("İletişim bilgisi silindi");
      }

      [HttpGet("{id}")]
      public IActionResult GetContact(int id) 
      { 
         var values= _contactService.TGetByID(id);
         return Ok(values);
      }
      [HttpPut]
      public IActionResult UpdateContatc(UpdateContactDto updateContactDto)
      {
         _contactService.TUpdate(new Contact()
         {

            ContactID = updateContactDto.ContactID,
            FooterDescription=updateContactDto.FooterDescription,
            Location=updateContactDto.Location,
            Mail = updateContactDto.Mail, 
            Phone=updateContactDto.Phone

         });
         return Ok("İletişim Bilgileri Güncelendi");
      }










   }
}
