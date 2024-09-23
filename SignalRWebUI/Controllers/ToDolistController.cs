using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.ToDoListDto;
using System.Text;

namespace SignalRWebUI.Controllers
{
	public class ToDolistController : Controller
	{

		private readonly IHttpClientFactory _httpClientFactory;

		public ToDolistController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


      //public async Task<IActionResult> Index()
      //{

      //	var client = _httpClientFactory.CreateClient();
      //	var responseMessage = await client.GetAsync("http://localhost:5013/api/ToDoLists");
      //	if (responseMessage.IsSuccessStatusCode)
      //	{
      //		var jsonData = await responseMessage.Content.ReadAsStringAsync();
      //		var values = JsonConvert.DeserializeObject<List<ResultToDoListDto>>(jsonData);
      //		return View(values);
      //	}

      //	return View();
      //}
      public async Task<IActionResult> Index()
      {
         var client = _httpClientFactory.CreateClient();

         // İlk olarak ToDoMinute verisini alıyoruz
         var responseMinuteMessage = await client.GetAsync("http://localhost:5013/api/ToDoLists/ToDoMinute");
         if (responseMinuteMessage.IsSuccessStatusCode)
         {
            var jsonMinuteData = await responseMinuteMessage.Content.ReadAsStringAsync();
            var minutesAgo = JsonConvert.DeserializeObject<int>(jsonMinuteData); // JSON verisini deserialization işlemi
            ViewBag.MinutesAgo = minutesAgo; // ViewBag ile dakika farkını View'a taşı
         }

         // Ardından ToDoList verilerini alıyoruz
         var responseMessage = await client.GetAsync("http://localhost:5013/api/ToDoLists");
         if (responseMessage.IsSuccessStatusCode)
         {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultToDoListDto>>(jsonData);
            return View(values);
         }

         return View();
      }

      [HttpGet]
		public IActionResult CreateToDolist()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> CreateToDolist(CreateToDoListDto createToDoListDto)
		{
			createToDoListDto.Date= DateTime.Now;
			var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(createToDoListDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMesaj = await client.PostAsync("http://localhost:5013/api/ToDoLists", stringContent);

			if (responseMesaj.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}


		public async Task<IActionResult> DeleteToDolist(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var response = await client.DeleteAsync($"http://localhost:5013/api/ToDoLists/{id}");
			if (response.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

		[HttpGet]
		public async Task<IActionResult> UpdateToDolist(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync($"http://localhost:5013/api/ToDoLists/{id}");

			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<UpdateToDoListDto>(jsonData);
				return View(values);
			}
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> UpdateToDolist(UpdateToDoListDto updateToDoListDto)
		{
         updateToDoListDto.Date = DateTime.Now;
         var client = _httpClientFactory.CreateClient();
			var jsonData = JsonConvert.SerializeObject(updateToDoListDto);
			StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
			var responseMessage = await client.PutAsync("http://localhost:5013/api/ToDoLists/", stringContent);
         updateToDoListDto.Date = DateTime.Now;
         if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return View();
		}

    



   }
}
