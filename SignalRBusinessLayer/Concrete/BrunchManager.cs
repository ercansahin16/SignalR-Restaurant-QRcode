using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
   public class BrunchManager:IBrunchServices
   {
      private readonly IBrunchDal _brunchDal;

      public BrunchManager(IBrunchDal brunchDal)
      {
         _brunchDal = brunchDal;
      }

      public void TAdd(Brunch entity)
      {
         throw new NotImplementedException();
      }

      public void TDelete(Brunch entity)
      {
         throw new NotImplementedException();
      }

      public Brunch TGetByID(int id)
      {
         throw new NotImplementedException();
      }

      public List<Brunch> TGetListAll()
      {
        return _brunchDal.GetListAll();
      }

      public void TUpdate(Brunch entity)
      {
         throw new NotImplementedException();
      }
   }
}
