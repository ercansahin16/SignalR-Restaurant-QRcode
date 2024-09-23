using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repository;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
   public class EFBookingDal : GenericRepository<Booking>, IBookingDal
   {
      public EFBookingDal(SignalRContext context) : base(context)
      {
      }

      public int TotalRezervision()
      {
         using var Context = new SignalRContext();
         var values=Context.bookings.Count();
         return values;
      }
   }
}
