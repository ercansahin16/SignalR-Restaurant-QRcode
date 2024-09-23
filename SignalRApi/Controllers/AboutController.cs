using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.AboutDto;
using SignalREntityLayer.Entities;
using System.Collections.Generic;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class AboutController : ControllerBase
   {
      private readonly IAboutService _aboutService;

      public AboutController(IAboutService aboutService)
      {
         _aboutService = aboutService;
      }


      [HttpGet]
      public IActionResult ListAbout()
      {
         var values= _aboutService.TGetListAll();
         return Ok(values);
      }

      [HttpPost]
      public IActionResult CreateAbout( CreateAboutDto createAboutDto)
      {
         About about = new About()
         {
            Description = createAboutDto.Description, 
            Title = createAboutDto.Title,
            ImageURL = createAboutDto.ImageURL

         };

         _aboutService.TAdd(about);
         return Ok("Hakkımda kısmı başarılı bir şekilde eklendi.");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteAbout(int id) 
      { 
      var values= _aboutService.TGetByID(id);
         _aboutService.TDelete(values);
         return Ok("Hakkımda alanı silindi");
      }

      [HttpPut]
      public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
      {
         About about = new About()
         {
            AboutID = updateAboutDto.AboutID,
            Title = updateAboutDto.Title,
            Description = updateAboutDto.Description,
            ImageURL = updateAboutDto.ImageURL
         };
         _aboutService.TUpdate(about);
         return Ok("Hakkımda kızmı güncelledi");

      }


      [HttpGet("{id}")]
      public IActionResult GetAbout(int id)
      {
         var values = _aboutService.TGetByID(id);
         return Ok(values);   

      }



   }
}
