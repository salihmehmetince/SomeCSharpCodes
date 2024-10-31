using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Web.Controllers.Helpers;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Helper helper;
        public HomeController(ILogger<HomeController> logger,Helper helper)
        {
            _logger = logger;
            this.helper = helper;
        }

        public IActionResult Index()
        {
            var text = "dsfjsjdfjsd";
            var upper=helper.Upper(text);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}