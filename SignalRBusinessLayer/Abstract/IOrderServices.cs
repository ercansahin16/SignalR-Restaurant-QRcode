using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Abstract
{
	public interface IOrderServices:IGenericServis<Order>
	{
		int TOrderCountTotal();
		int TActiveTable();
		decimal TLastOrderPrice();
		decimal TSafeByTotalPrice();
		decimal TTotalPriceToday();
		int TTableCount();

		int TOrderByTodayCount();
	}
}
