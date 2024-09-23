using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace SignalRWebUI.ViewComponents._IULayoutComponentPartial
{
   public class _UILayoutSpinnerComponentPartial:ViewComponent
   {
     public IViewComponentResult Invoke()
      {
         return View();
      }

   }
}
