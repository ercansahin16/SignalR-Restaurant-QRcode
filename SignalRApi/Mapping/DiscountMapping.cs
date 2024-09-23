using AutoMapper;
using SignalRDtoLayer.CategoryDto;
using SignalRDtoLayer.DicountDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
   public class DiscountMapping:Profile
   {
        public DiscountMapping()
        {
         CreateMap<Discount, ResultDiscountDto>().ReverseMap();
         CreateMap<Discount, CreateDiscountDto>().ReverseMap();
         CreateMap<Discount, GetDiscountDto>().ReverseMap();
         CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
      }
    }
}
