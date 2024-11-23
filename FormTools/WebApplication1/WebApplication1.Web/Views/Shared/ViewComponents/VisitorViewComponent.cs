using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Web.Views.Shared.ViewComponents
{
    public class VisitorViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
