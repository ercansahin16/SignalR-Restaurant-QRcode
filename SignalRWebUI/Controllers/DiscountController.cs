using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.CategoryDto;
using SignalRWebUI.Dtos.DicountDto;
using System.Text;

namespace SignalRWebUI.Controllers
{
    public class DiscountController : Controller
    {
      private readonly IHttpClientFactory _httpClientFactory;

      public DiscountController(IHttpClientFactory httpClientFactory)
      {
         _httpClientFactory = httpClientFactory;
      }

      public async Task<IActionResult> Index()
      {
         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync("http://localhost:5013/api/Discount");
         if (responseMessage.IsSuccessStatusCode)
         {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
            return View(values);
         }

         return View();
      }

      [HttpGet]
      public IActionResult CreateDiscount()
      {
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> CreateDiscount(CreateDiscountDto createDiscountDto)
      {
         var client = _httpClientFactory.CreateClient();
         var jsonData = JsonConvert.SerializeObject(createDiscountDto);
         StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
         var responseMesaj = await client.PostAsync("http://localhost:5013/api/Discount", stringContent);

         if (responseMesaj.IsSuccessStatusCode)
         {
            return RedirectToAction("Index");
         }
         return View();
      }


      public async Task<IActionResult> DeleteDiscount(int id)
      {
         var client = _httpClientFactory.CreateClient();
         var response = await client.DeleteAsync($"http://localhost:5013/api/Discount/{id}");
         if (response.IsSuccessStatusCode)
         {
            return RedirectToAction("Index");
         }
         return View();
      }

      [HttpGet]
      public async Task<IActionResult> UpdateDiscount(int id)
      {
         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync($"http://localhost:5013/api/Discount/{id}");

         if (responseMessage.IsSuccessStatusCode)
         {
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<UpdateDiscountDto>(jsonData);
            return View(values);
         }
         return View();
      }

      [HttpPost]
      public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
      {
         var client = _httpClientFactory.CreateClient();
         var jsonData = JsonConvert.SerializeObject(updateDiscountDto);
         StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
         var responseMessage = await client.PutAsync("http://localhost:5013/api/Discount/", stringContent);

         if (responseMessage.IsSuccessStatusCode)
         {
            return RedirectToAction("Index");
         }
         return View();
      }


   










   }
}
