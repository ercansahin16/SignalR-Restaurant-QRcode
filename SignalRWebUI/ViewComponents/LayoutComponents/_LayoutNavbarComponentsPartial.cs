using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
    public class _LayoutNavbarComponentsPartial:ViewComponent

    {
      public IViewComponentResult Invoke()
         { return View(); }
    }
}
