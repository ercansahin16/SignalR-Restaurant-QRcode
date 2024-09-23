using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.BrunchDto;
using SignalRDtoLayer.DicountDto;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class BrunchController : ControllerBase
   {
      private readonly IBrunchServices _brunchServices;
      private readonly IMapper _mapper;

      public BrunchController(IBrunchServices brunchServices, IMapper mapper)
      {
         _brunchServices = brunchServices;
         _mapper = mapper;
      }
      [HttpGet]
      public IActionResult FeatureGet()
      {
         var values = _mapper.Map<List<ResultBrunchDto>>(_brunchServices.TGetListAll());
         return Ok(values);
      }


   }
}
