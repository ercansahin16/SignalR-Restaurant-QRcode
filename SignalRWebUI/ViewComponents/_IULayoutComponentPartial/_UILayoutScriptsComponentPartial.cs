using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._IULayoutComponentPartial
{
   public class _UILayoutScriptsComponentPartial:ViewComponent
   {
      public IViewComponentResult Invoke()
      {
         return View();
      }
   }
}
