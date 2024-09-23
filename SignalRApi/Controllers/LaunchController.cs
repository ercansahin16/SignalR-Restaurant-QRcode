using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.FeatureDto;
using SignalRDtoLayer.LauncheDto;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class LaunchController : ControllerBase
   {
      private readonly ILauncheServices _launcheServices;
      private readonly IMapper _mapper;

      public LaunchController(ILauncheServices launcheServices, IMapper mapper)
      {
         _launcheServices = launcheServices;
         _mapper = mapper;
      }

      [HttpGet]
      public IActionResult LaunchGet() 
      {
         var values = _mapper.Map<List<ResultLauncheDto>>(_launcheServices.TGetListAll());
         return Ok(values);
      }
   }
}
