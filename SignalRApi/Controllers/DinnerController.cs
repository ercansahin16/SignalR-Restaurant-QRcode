using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.DicountDto;
using SignalRDtoLayer.DinnerDto;
using SignalRDtoLayer.FeatureDto;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class DinnerController : ControllerBase
   {
      private readonly IDinnerServices _dinnerServices;
      private readonly IMapper _mapper;

      public DinnerController(IDinnerServices dinnerServices, IMapper mapper)
      {
         _dinnerServices = dinnerServices;
         _mapper = mapper;
      }

      [HttpGet]
      public IActionResult DinnerGet()
      {
         var values = _mapper.Map<List<ResultDinnerDto>>(_dinnerServices.TGetListAll());
         return Ok(values);
      }
   }
}
