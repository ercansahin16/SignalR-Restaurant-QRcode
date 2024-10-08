﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
   public interface IGenericServis<T>where T : class
   {
      void TAdd(T entity);
      void TDelete(T entity);
      void TUpdate(T entity);
      T TGetByID(int id);
      List<T> TGetListAll();
   }
}
