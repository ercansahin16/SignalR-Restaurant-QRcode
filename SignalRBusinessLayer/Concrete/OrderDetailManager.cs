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
	public class OrderDetailManager : IOrderDetailServices
	{
		private readonly IOrderDetailDal _orderDetailDal;

		public OrderDetailManager(IOrderDetailDal orderDetailDal)
		{
			_orderDetailDal = orderDetailDal;
		}

		public void TAdd(OrderDetail entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(OrderDetail entity)
		{
			throw new NotImplementedException();
		}

		public OrderDetail TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<OrderDetail> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(OrderDetail entity)
		{
			throw new NotImplementedException();
		}
	}
}
