using AutoMapper;
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

        private readonly IMapper mapper;
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

            var productsList=appDBContext.Products.OrderByDescending(p=>p.Id).Select(x=>new ProductPartialViewModel() { Id=x.Id,Name=x.Name,Price=x.Price,Stock=x.stock??0}).ToList();
            ViewData["ProductListViewModelList"] = new ProductListViewModel()
            {
                products = productsList
            };
            return View();
        }

        public IActionResult Privacy()
        {
            var productsList = appDBContext.Products.OrderByDescending(p => p.Id).Select(x => new ProductPartialViewModel() { Id = x.Id, Name = x.Name, Price = x.Price, Stock = x.stock ?? 0 }).ToList();
            ViewData["ProductListViewModelList"] = new ProductListViewModel()
            {
                products = productsList
            };
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Visitor()
        {

            return View();
        }

        [HttpPost]
        public IActionResult addVisitor(VisitorViewModel visitorViewModel)
        {
            try
            {
                var visitor = mapper.Map<Visitor>(visitorViewModel);
                appDBContext.Visitors.Add(visitor);
                appDBContext.SaveChanges();
                TempData["status"] = "Successfully saved";
                return RedirectToAction(nameof(HomeController.Visitor));
            }
            catch(Exception e)
            {
                TempData["status"] = "An error occurred"+e.Message;
                return RedirectToAction(nameof(HomeController.Visitor));
            }
        }
    }
}