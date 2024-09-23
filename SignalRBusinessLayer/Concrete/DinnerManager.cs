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
   public class DinnerManager:IDinnerServices
   {
      private readonly IDinnerDal _dinnerDal;

      public DinnerManager(IDinnerDal dinnerDal)
      {
         _dinnerDal = dinnerDal;
      }

      public void TAdd(Dinner entity)
      {
         throw new NotImplementedException();
      }

      public void TDelete(Dinner entity)
      {
         throw new NotImplementedException();
      }

      public Dinner TGetByID(int id)
      {
         throw new NotImplementedException();
      }

      public List<Dinner> TGetListAll()
      {
         return _dinnerDal.GetListAll();
      }

      public void TUpdate(Dinner entity)
      {
         throw new NotImplementedException();
      }
   }
}
