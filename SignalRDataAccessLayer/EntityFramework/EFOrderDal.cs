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
	public class EFOrderDal : GenericRepository<Order>, IOrderDal
	{
		public EFOrderDal(SignalRContext context) : base(context)
		{
		}

		public int ActiveTable()
		{
			using var context = new SignalRContext(); 
			var values=context.orders.Where(x=>x.Description=="A").Count();
			return values;
		}

		public decimal LastOrderPrice()
		{
			using var context=new SignalRContext();
			var values=context.orders.OrderByDescending(x => x.TotalPrice).FirstOrDefault().TotalPrice;
			return values;
		}

		public int OrderCountTotal()
		{
			using var context = new SignalRContext();
			var values = context.orders.Count();
			return values;
		}

		public int  OrderByTodayCount()
		{
			using var context = new SignalRContext();
			var values = context.orders.Where(x=>x.Data==DateTime.Today).Count();
			return values;
		}

		public decimal SafeByTotalPrice()
		{
			using var context= new SignalRContext();
			var values=context.orders.Sum(x => x.TotalPrice);
			return values;
		}

		public int TableCount()
		{
			using var context = new SignalRContext();
			var values = context.orders.Select(x => x.TableNumber).Count() ;
			return values;
		}

		public decimal TotalPriceToday()
		{
			using var context = new SignalRContext();
			var values = context.orders.Where(x => x.Data == DateTime.Today).Sum(y=>y.TotalPrice);
			return values;
		}
	}
}
