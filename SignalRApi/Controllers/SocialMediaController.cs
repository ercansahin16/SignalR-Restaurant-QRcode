﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.SocialMediaDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class SocialMediaController : ControllerBase
   {
      private readonly ISocialMediaService _socialMediaService;
      private readonly IMapper _mapper;

      public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
      {
         _socialMediaService = socialMediaService;
         _mapper = mapper;
      }

      [HttpGet]
      public IActionResult SocialMediaList() 
      {
         var values = _mapper.Map<List<ResultSocialMediaDto>>(_socialMediaService.TGetListAll());
         return Ok(values);
      }


      [HttpPost]
      public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
      {
         _socialMediaService.TAdd(new SocialMedia()
         {
            Title = createSocialMediaDto.Title,
            Url = createSocialMediaDto.Url,
            Icon = createSocialMediaDto.Icon
         });
         return Ok("Sosyal media bilgisi eklendi");
      }


      [HttpDelete("{id}")]
      public IActionResult DeleteSocialMedia(int id) 
      {
         var values=_socialMediaService.TGetByID(id);
         _socialMediaService.TDelete(values);
         return Ok("Sosyal media bilgisi silindi");
      }

      [HttpGet("{id}")]
      public IActionResult GetSocialMedia(int id) 
      
      {
         var values = _socialMediaService.TGetByID(id);
         return Ok(values);
      
      }

      [HttpPut]
      public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
      {
         _socialMediaService.TUpdate(new SocialMedia()
         {
            Title=updateSocialMediaDto.Title,   
            Url=updateSocialMediaDto.Url,
            Icon=updateSocialMediaDto.Icon,
            SocialMediaID=updateSocialMediaDto.SocialMediaID
         });
         return Ok("Social Media bilgisi güncellendi");
      }



   }
}
