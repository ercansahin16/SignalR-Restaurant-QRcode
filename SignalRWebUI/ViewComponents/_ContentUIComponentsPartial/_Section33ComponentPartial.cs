using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.DinnerDto;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class _Section33ComponentPartial:ViewComponent
   {
      private readonly IHttpClientFactory _httpClientFactory;

      public _Section33ComponentPartial(IHttpClientFactory httpClientFactory)
      {
         _httpClientFactory = httpClientFactory;
      }

      public async Task<IViewComponentResult> InvokeAsync()
      {

         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync("http://localhost:5013/api/Dinner");

         var jsonData = await responseMessage.Content.ReadAsStringAsync();
         var values = JsonConvert.DeserializeObject<List<ResultDinnerDto>>(jsonData);
         return View(values);
      }
   }
}
