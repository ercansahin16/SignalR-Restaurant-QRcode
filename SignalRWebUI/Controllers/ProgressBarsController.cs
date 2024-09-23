using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace SignalRWebUI.Controllers
{
   public class ProgressBarsController : Controller
   {

		private readonly IHttpClientFactory _httpClientFactory;

		public ProgressBarsController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}




		

	}
}
