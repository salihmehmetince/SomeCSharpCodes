using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using WebApplication1.Web.Controllers.Helpers;
using WebApplication1.Web.Models;

namespace WebApplication1.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository _productRepository;

        private AppDBContext appDBContext;

        private IHelper helper;
        public ProductController(AppDBContext appDBContext,IHelper helper)//construction injection via DI container
        {
            _productRepository = new ProductRepository();
            //Dependecy Injection design paterni
            //Burada DI container appDBContext parametresi ile sağlandı.
            this.appDBContext = appDBContext;
            this.helper = helper;
            if(!appDBContext.Products.Any())
            {
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color="Blue",Height=100,Width=200});
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color = "Red", Height = 10, Width = 100 });
                appDBContext.Products.Add(new() { Name="Product1",Type="Type2",Price=1000,Color = "Yellow", Height = 200, Width = 200 });
                appDBContext.SaveChanges();
            }
        }

        public IActionResult Index([FromServices] IHelper helper2)//method injection via DI Container
        {
            List<Product> products = appDBContext.Products.ToList();
            var text = "dsbdjfjsdj";
            var upperTex=helper.Upper(text);
            var status = "";
            if(this.helper.Equals(helper2))
            {
                status = "True";
            }
            else
            {
                status = "False";
            }
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
            var expirationDates = new Dictionary<string, int>() { {"1 ay",1 }, { "3 ay", 3 }, { "6 ay", 6 }, { "12 ay", 12 } };
            ViewData["ExpirationDate"] = expirationDates;
            ViewData["Color"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                new List<WebApplication1.Web.Models.Color>()
                {
                    new(){colorName="Blue",colorValue="Blue"},
                    new(){colorName="Yellow",colorValue="Yellow"},
                    new(){colorName="Red",colorValue="Red"},
                },
                "colorValue",
                "colorName"
                );
            return View();
        }

        [HttpPost]
        public IActionResult addProduct(Product product)//model binding ile veri alma
        {
            /*var pName = HttpContext.Request.Form["pName"].ToString();
            var pType = HttpContext.Request.Form["pType"].ToString();
            var pPrice = decimal.Parse(HttpContext.Request.Form["pPrice"].ToString());
            var pColor = HttpContext.Request.Form["pColor"].ToString();
            var pHeight = int.Parse(HttpContext.Request.Form["pHeight"].ToString());
            var pWidth = int.Parse(HttpContext.Request.Form["pWidth"].ToString());*/

            /*Product product = new Product();
            product.Name = pName;
            product.Type = pType;
            product.Price = pPrice;
            product.Color = pColor;
            product.Height = pHeight;
            product.Width = pWidth;*/
            appDBContext.Products.Add(product);
            appDBContext.SaveChanges();
            TempData["status"] = "Sucessfully added";
            return RedirectToAction("Index", "Product");
        }


        [HttpGet]//default value
        public IActionResult addProductGet(Product product)
        {
            return View();
        }

        public IActionResult update(int id)
        {
            var product = appDBContext.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult updateProduct(Product product,int Id)
        {
            product.Id = Id;
            appDBContext.Products.Update(product);
            appDBContext.SaveChanges();
            TempData["Status"] = "Successfully Updated";
            return RedirectToAction("Index");
        }
    }
}
