using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;

namespace SignalRWebUI.ViewComponents._IULayoutComponentPartial
{
   public class _UILayoutFooterComponentPartial:ViewComponent

   {

      public IViewComponentResult Invoke()
      {
         return View(); 
      }
   }
}
