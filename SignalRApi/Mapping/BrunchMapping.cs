using AutoMapper;
using SignalRDtoLayer.BrunchDto;
using SignalRDtoLayer.DicountDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
   public class BrunchMapping:Profile
   {
      public BrunchMapping()
      {
         CreateMap<Brunch, ResultBrunchDto>().ReverseMap();
         CreateMap<Brunch, CreateBrunchDto>().ReverseMap();
         CreateMap<Brunch, GetBrunchtDto>().ReverseMap();
         CreateMap<Brunch, UpdateBrunchDto>().ReverseMap();
      }

   }
}
