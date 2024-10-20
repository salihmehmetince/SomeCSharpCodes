using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
