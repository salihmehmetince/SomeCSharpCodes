using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        private AppDBContext appDBContext;

        public ProductController(AppDBContext appDBContext)
        {
            _productRepository = new ProductRepository();
            //Dependecy Injection design paterni
            //Burada DI container appDBContext parametresi ile sağlandı.
            this.appDBContext = appDBContext;

            if(!appDBContext.Products.Any())
            {
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color="Blue",Height=100,Width=200});
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color = "Red", Height = 10, Width = 100 });
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color = "Yellow", Height = 200, Width = 200 });
                appDBContext.SaveChanges();
            }
        }

        public IActionResult Index()
        {
            List<Product> products = appDBContext.Products.ToList();
            return View(products);
        }

        public IActionResult delete(int id)
        {
            //_productRepository.delete(id);
            var product =appDBContext.Products.Find(id);
            if(product!=null)
            {
                appDBContext.Products.Remove(product);
                appDBContext.SaveChanges();
            }
            return RedirectToAction("Index","Product");
        }

        public IActionResult add()
        {
            return View();
        }

        public IActionResult update(int id)
        {
            return View();
        }
    }
}
