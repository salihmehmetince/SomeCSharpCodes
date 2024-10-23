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

            if(!_productRepository.getProducts.Any())
            {
                _productRepository.add(new() { Id=1,Name="asd",Type="dsa",Price=1000});
                _productRepository.add(new() { Id=2,Name="add",Type="dsa",Price=4000});
                _productRepository.add(new() { Id=3,Name="afd",Type="ssa",Price=2000});
                _productRepository.add(new() { Id=4,Name="agd",Type="ssa",Price=4000});
            }
        }

        public IActionResult Index()
        {
            List<Product> products = _productRepository.getProducts as List<Product>;
            return View(products);
        }
    }
}
