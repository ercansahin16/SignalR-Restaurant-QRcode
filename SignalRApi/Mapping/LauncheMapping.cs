using AutoMapper;
using SignalRDtoLayer.DicountDto;
using SignalRDtoLayer.FeatureDto;
using SignalRDtoLayer.LauncheDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
   public class LauncheMapping : Profile
   {
      public LauncheMapping()
      {
         CreateMap<Launch, ResultLauncheDto>().ReverseMap();
         CreateMap<Launch, CreateLauncheDto>().ReverseMap();
         CreateMap<Launch, GetLauncheDto>().ReverseMap();
         CreateMap<Launch, UpdateLauncheDto>().ReverseMap();
      }
   }
}
