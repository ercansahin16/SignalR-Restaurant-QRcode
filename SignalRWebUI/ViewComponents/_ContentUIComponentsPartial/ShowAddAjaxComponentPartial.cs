using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents._ContentUIComponentsPartial
{
   public class ShowAddAjaxComponentPartial:ViewComponent
   {
      public IViewComponentResult Invoke()
      { 
         
         return View(); 
      
      }
   }
}
