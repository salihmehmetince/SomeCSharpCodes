using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }

        public IActionResult Index()
        {
            List<Product> products = _productRepository.getProducts as List<Product>;
            return View(products);
        }

        public IActionResult delete(int id)
        {
            _productRepository.delete(id);
            return RedirectToAction("Index","Product",id);
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
