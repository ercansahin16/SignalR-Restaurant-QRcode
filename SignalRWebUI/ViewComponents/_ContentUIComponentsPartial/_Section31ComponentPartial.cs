using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.BrunchDto;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class _Section31ComponentPartial : ViewComponent

   {
      private readonly IHttpClientFactory _httpClientFactory;

      public _Section31ComponentPartial(IHttpClientFactory httpClientFactory)
      {
         _httpClientFactory = httpClientFactory;
      }
      public async Task<IViewComponentResult> InvokeAsync()
      {
         
         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync("http://localhost:5013/api/Brunch");

         var jsonData = await responseMessage.Content.ReadAsStringAsync();
         var values = JsonConvert.DeserializeObject<List<ResultBrunchDto>>(jsonData);
         return View(values);
      }

   }
}
