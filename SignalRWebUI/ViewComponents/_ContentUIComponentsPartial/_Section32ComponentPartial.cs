using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.LauncheDto;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class _Section32ComponentPartial : ViewComponent
   {
      private readonly IHttpClientFactory _httpClientFactory;

      public _Section32ComponentPartial(IHttpClientFactory httpClientFactory)
      {
         _httpClientFactory = httpClientFactory;
      }

      public async Task<IViewComponentResult> InvokeAsync()
      {

         var client = _httpClientFactory.CreateClient();
         var responseMessage = await client.GetAsync("http://localhost:5013/api/Launch");

         var jsonData = await responseMessage.Content.ReadAsStringAsync();
         var values = JsonConvert.DeserializeObject<List<ResultLauncheDto>>(jsonData);
         return View(values);
      }
   }
}