using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.TestimonialDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class TestimonialController : ControllerBase
   {

      private readonly ITestimonialService _testimonialService;
      private readonly IMapper _mapper;

      public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
      {
         _testimonialService = testimonialService;
         _mapper = mapper;
      }


      [HttpGet]
      public IActionResult TestimonialList()
      {
         var values = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
         return Ok(values);
      }

      [HttpPost]
      public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
      {
         _testimonialService.TAdd(new Testimonial()
         {
            Name = createTestimonialDto.Name,
            Comment = createTestimonialDto.Comment,
            TestimonialStatus= createTestimonialDto.TestimonialStatus,
            Tittle = createTestimonialDto.Tittle
       
         });
         return Ok("Referans eklendi");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteTestimonial(int id)
      {
         var values = _testimonialService.TGetByID(id);
         _testimonialService.TDelete(values);
         return Ok("Referans silindi");
      }

      [HttpGet("{id}")]
      public IActionResult GetTestimonial(int id)
      {
         var values = _testimonialService.TGetByID(id);
         return Ok(values);   
      }

      [HttpPut]
      public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
      {
         _testimonialService.TUpdate(new Testimonial()
         {
            TestimonialStatus= updateTestimonialDto.TestimonialStatus,
            Comment= updateTestimonialDto.Comment,
            Name= updateTestimonialDto.Name,
            Tittle= updateTestimonialDto.Tittle,
            TestimonialID=updateTestimonialDto.TestimonialID
            
         });
         return Ok("Referans güncellendi");
      }






   }




}
