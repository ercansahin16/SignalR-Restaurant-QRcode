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
   public class EFBrunchDal : GenericRepository<Brunch>, IBrunchDal
   {
      public EFBrunchDal(SignalRContext context) : base(context)
      {
      }
   }
}
