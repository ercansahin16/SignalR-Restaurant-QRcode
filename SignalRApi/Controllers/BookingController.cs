using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.BookingDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
   [Route("api/[controller]")]
   [ApiController]
   public class BookingController : ControllerBase
   {
      private readonly IBookingService _bookingService;

      public BookingController(IBookingService bookingService)
      {
         _bookingService = bookingService;
      }

      [HttpGet]
      public IActionResult BookingList() 
      {
      var values= _bookingService.TGetListAll();
         return Ok(values);
      }

      [HttpGet("TotalRezervision")]
      public IActionResult TotalRezervision() 
      {
         var values = _bookingService.TTotalRezervision();
         return Ok(values);
      }

      [HttpPost]
     public IActionResult CreateBooking(CreateBasketDto createBookingDto)
      {
         Booking booking = new Booking()
         {
            Date = createBookingDto.Date,
            Name = createBookingDto.Name,
            Phone = createBookingDto.Phone,
            Mail = createBookingDto.Mail,
            PersonCount = createBookingDto.PersonCount,
         };
         _bookingService.TAdd(booking);
         return Ok("Rezervasyon yapıldı.");
      }

      [HttpDelete("{id}")]
      public IActionResult DeleteBooking(int id)
      {
         var values = _bookingService.TGetByID(id);
         _bookingService.TDelete(values);
         return Ok("Rezervasyon silindi");
      }

      [HttpPut]
      public IActionResult UpdateBooking(UpdateBasketDto updateBookingDto)
      {

         Booking booking = new Booking()
         {
            BookingID = updateBookingDto.BookingID,
            Date = updateBookingDto.Date,
            Name = updateBookingDto.Name,
            Phone = updateBookingDto.Phone,
            Mail = updateBookingDto.Mail,
            PersonCount = updateBookingDto.PersonCount
         };
         _bookingService.TUpdate(booking);
         return Ok("Rezervasyonunuz güncellendi");
      }

      [HttpGet("{id}")]
      public IActionResult GetBooking(int id)
      {
         var values=_bookingService.TGetByID(id);
         return Ok(values);
      }







   }
}
