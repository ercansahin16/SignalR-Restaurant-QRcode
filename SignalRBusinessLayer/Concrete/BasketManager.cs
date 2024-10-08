﻿using SignalRBusinessLayer.Abstract;
using SignalRDataAccessLayer.Abstract;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
   public class BasketManager : IBasketServices
   {
      private readonly IBasketDal _basketDal;

      public BasketManager(IBasketDal basketDal)
      {
         _basketDal = basketDal;
      }

      public void TAdd(Basket entity)
      {
         throw new NotImplementedException();
      }

      public void TDelete(Basket entity)
      {
         throw new NotImplementedException();
      }

      public Basket TGetByID(int id)
      {
         throw new NotImplementedException();
      }

      public List<Basket> TGetListAll()
      {
         throw new NotImplementedException();
      }

      public void TUpdate(Basket entity)
      {
         throw new NotImplementedException();
      }
   }
}
