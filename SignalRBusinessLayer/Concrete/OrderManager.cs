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
	public class OrderManager : IOrderServices
	{
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public int TActiveTable()
		{
			return _orderDal.ActiveTable();
		}

		public void TAdd(Order entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Order entity)
		{
			throw new NotImplementedException();
		}

		public Order TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Order> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public decimal TLastOrderPrice()
		{
			return _orderDal.LastOrderPrice();
		}

		public int TOrderByTodayCount()
		{
			return _orderDal.OrderByTodayCount();
		}

		public int TOrderCountTotal()
		{
			return _orderDal.OrderCountTotal();
		}

		public decimal TSafeByTotalPrice()
		{
			return _orderDal.SafeByTotalPrice();
		}

		public int TTableCount()
		{
			return _orderDal.TableCount();
		}

		public decimal TTotalPriceToday()
		{
			return _orderDal.TotalPriceToday();
		}

		public void TUpdate(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}
