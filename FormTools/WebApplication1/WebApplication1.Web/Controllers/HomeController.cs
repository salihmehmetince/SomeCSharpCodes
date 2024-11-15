using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Web.Controllers.Helpers;
using WebApplication1.Web.Models;
using WebApplication1.Web.Models.ViewModels;

namespace WebApplication1.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Helper helper;

        private readonly AppDBContext appDBContext;
        public HomeController(ILogger<HomeController> logger,Helper helper, AppDBContext appDBContext)
        {
            _logger = logger;
            this.helper = helper;
            this.appDBContext = appDBContext;
        }

        public IActionResult Index()
        {
            var text = "dsfjsjdfjsd";
            var upper=helper.Upper(text);

            var products=appDBContext.Products.OrderByDescending(p=>p.Id).Select(x=>new ProductPartialViewModel() { Id=x.Id,Name=x.Name,Price=x.Price,Stock=(int)x.stock}).ToList();
            ViewData["ProductListViewModel"] = new ProductListViewModel()
            {
                products = products
            };
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