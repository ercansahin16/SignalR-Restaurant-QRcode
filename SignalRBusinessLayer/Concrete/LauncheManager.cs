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
   public class LauncheManager:ILauncheServices
   {
      private readonly ILauncheDal _launcheDal;

      public LauncheManager(ILauncheDal launcheDal)
      {
         _launcheDal = launcheDal;
      }

      public void TAdd(Launch entity)
      {
         throw new NotImplementedException();
      }

      public void TDelete(Launch entity)
      {
         throw new NotImplementedException();
      }

      public Launch TGetByID(int id)
      {
         throw new NotImplementedException();
      }

      public List<Launch> TGetListAll()
      {
         return _launcheDal.GetListAll();
      }

      public void TUpdate(Launch entity)
      {
         throw new NotImplementedException();
      }
   }
}
