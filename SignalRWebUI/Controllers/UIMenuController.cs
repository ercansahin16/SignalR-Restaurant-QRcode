using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.Controllers
{
   public class UIMenuController : Controller
   {
      public IActionResult Index()
      {
         return View();
      }
   }
}
