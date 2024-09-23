using AutoMapper;
using SignalRDtoLayer.BookingDto;
using SignalRDtoLayer.CategoryDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
   public class BookingMapping:Profile
   {
        public BookingMapping()
        {
         CreateMap<Booking, ResultBasketDto>().ReverseMap();
         CreateMap<Booking, CreateBasketDto>().ReverseMap();
         CreateMap<Booking, GetBasketDto>().ReverseMap();
         CreateMap<Booking, UpdateBasketDto>().ReverseMap();
      }
    }
}
