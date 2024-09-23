using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.Abstract
{
	public interface IOrderDal:IGenericDal<Order>
	{
		int OrderCountTotal();
		int ActiveTable();
		decimal LastOrderPrice();
		decimal SafeByTotalPrice();
		decimal TotalPriceToday();
		int TableCount();
		int OrderByTodayCount();
	}
}
