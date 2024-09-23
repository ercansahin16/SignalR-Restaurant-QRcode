using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
   public class UIDefaultController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
