using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptsComponentsPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
			{ return View(); }
	}
}
