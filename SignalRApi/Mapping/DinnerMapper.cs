using AutoMapper;
using SignalRDtoLayer.DinnerDto;
using SignalRDtoLayer.DinnerDto;
using SignalRDtoLayer.FeatureDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
   public class DinnerMapper : Profile
   {
      public DinnerMapper()
      {
         CreateMap<Dinner, ResultDinnerDto>().ReverseMap();
         CreateMap<Dinner, CreateDinnerDto>().ReverseMap();
         CreateMap<Dinner, GetDinnerDto>().ReverseMap();
         CreateMap<Dinner, UpdateDinnerDto>().ReverseMap();
      }
   }
}
