using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.DicountDto;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class _Section3ComponentPartial : ViewComponent//Discount For
   {
      private readonly IHttpClientFactory _httpClientFactory;

      public _Section3ComponentPartial(IHttpClientFactory httpClientFactory)
      {
         _httpClientFactory = httpClientFactory;
      }

      public async Task<IViewComponentResult> InvokeAsync()
      {
         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync("http://localhost:5013/api/Discount");

         var jsonData = await responseMessage.Content.ReadAsStringAsync();
         var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
         return View(values);
      }









   }
}
