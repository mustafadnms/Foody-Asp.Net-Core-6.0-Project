using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponents.AdminLayoutViewComponent
{
	public class _CustomTemplateLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();	
		}
	}
}
