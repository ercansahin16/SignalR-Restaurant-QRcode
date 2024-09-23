using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.DicountDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class DiscountController : ControllerBase
   {
      private readonly IDiscountService _discountService;
      private readonly IMapper _mapper;

      public DiscountController(IDiscountService discountService, IMapper mapper)
      {
         _discountService = discountService;
         _mapper = mapper;
      }



      [HttpGet]
      public IActionResult DiscountList() 
      
      {
         var values = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
         return Ok(values);         
      }

      [HttpPost]
      public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
      {
         _discountService.TAdd(new Discount()
         {
            Amount = createDiscountDto.Amount,
            Description = createDiscountDto.Description,
            ImageUrl = createDiscountDto.ImageUrl,
            Title = createDiscountDto.Title
          
         });
         return Ok("İndirim bilgisi eklendi");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteDiscount(int id) 
      
      {
      var values=_discountService.TGetByID(id);
         _discountService.TDelete(values);
         return Ok("İndirim oranı silindi");
      }

      [HttpGet("{id}")]

      public   IActionResult GetDiscount(int id)
      {
         var values=_discountService.TGetByID(id);
         return Ok(values);   
      }
      [HttpPut]
      public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
      {
         _discountService.TUpdate(new Discount()
         { 
         Amount=updateDiscountDto.Amount,
         Description=updateDiscountDto.Description,
         ImageUrl=updateDiscountDto.ImageUrl,
         Title = updateDiscountDto.Title,
         DiscountID=updateDiscountDto.DiscountID
         });
         return Ok("İndirim bilgisi güncellendi");
      }






   }

}
