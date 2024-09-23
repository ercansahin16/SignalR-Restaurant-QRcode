using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class _Section1ComponentPartial:ViewComponent
   {
      public IViewComponentResult Invoke()
      {
         return View();
      }
   }
}
