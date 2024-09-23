using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly IOrderServices _orderServices;

		public OrdersController(IOrderServices orderServices)
		{
			_orderServices = orderServices;
		}

		[HttpGet("OrderCountTotal")]
		public IActionResult OrderCountTotal()
		{
			
			var values= _orderServices.TOrderCountTotal();
			return Ok(values);
		}
		[HttpGet("ActiveTable")]
		public IActionResult ActiveTable()
		{

			var values = _orderServices.TActiveTable();
			return Ok(values);
		}

		[HttpGet("LastOrderPrice")]
		public IActionResult LastOrderPrice()
		{

			var values = _orderServices.TLastOrderPrice();
			return Ok(values);
		}

		[HttpGet("SafeByTotalPrice")]
		public IActionResult SafeByTotalPrice() 
		{

			var values = _orderServices.TSafeByTotalPrice();
			return Ok(values);
		}
		[HttpGet("TotalPriceToday")]
		public IActionResult TotalPriceToday()
		{

			var values = _orderServices.TTotalPriceToday();
			return Ok(values);
		}

		[HttpGet("TableCount")] 
		public IActionResult TableCount()
		{

			var values = _orderServices.TTableCount();
			return Ok(values);
		}


		[HttpGet("OrderByTodayCount")]
		public IActionResult OrderByTodayCount()     
		{

			var values = _orderServices.TOrderByTodayCount();
			return Ok(values);
		}



	}
}
