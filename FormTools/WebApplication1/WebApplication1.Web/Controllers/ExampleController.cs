using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Web.Controllers
{
    public class Product2
    {
        private int id;
        private string type;
        private string name;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type { 
            get { return type; }
            set { type = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


    }

    public class ExampleController : Controller
    {
        //index action metodu çalıştığında view yani html sayfası döndürür bunu yapabilmek için
        //cshtml sayfasının oluşturulmuş olması gerekir.
        //baseURL+controllerName+actionMethod
        public IActionResult Index()
        {
            /*ViewBag.name = "asddasda";
            ViewBag.number = 123;
            ViewBag.grades=new List<int>(new int[] { 100, 20, 30 });
            ViewData["name2"] = "sdfjshjdf";
            ViewData["numbers2"]=new List<int>(new int[] { 433,4343,434});
            ViewData["Note2"] = "Warninnnnnnnnngg:)";
            TempData["TempName"] = "Temp name";*/
            Product2[] products = new Product2[3];
            products[0] = new Product2();
            products[1] = new Product2();
            products[2] = new Product2();
            products[0].Id = 1;
            products[0].Type = "Small house appliences";
            products[0].Name = "Mixer";
            products[1].Id = 2;
            products[1].Type = "White goods";
            products[1].Name = "Cooker";
            products[2].Id = 3;
            products[2].Type = "White goods";
            products[2].Name = "Fridge";

            return View(products);
            //view dışında farklı dönüş tipleri de vardır.
            //bunlara örnek olarak:
            //content string döndürmek için
            //json json nesnesi döndürmek için
            //empty hiç bir şey döndürmemek için örnek verilebilir.
            //TempData[""] action metot ile başka bir action metoda  ve action metpt ile başka
            //bir action metodun view ine veri yollamak için kullanılır
        }

        public IActionResult Index2()
        {
            //string name = TempData["TempName"].ToString();
            //ViewBag.tempName=name;
            return View();
        }
        public IActionResult Index3(int id)
        {
            //bir sayfaya gitmeye çalışıldığında başka bir sayfaya yönlendirir
            //return RedirectToAction("Index","Example");
            return RedirectToAction("ParameterResult","Example",new {id=id});
        }

        public IActionResult ContentResult()
        {
            return Content("merhaba bu bir string ve content olarak döndü");
        }

        public IActionResult JSONResult()
        {
            return Json(new { name = "asasdd", number = 123, other = "dsdsffs" });
        }

        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        public IActionResult ParameterResult(int id)
        {
            return Json (new {number=id,name="dsfdfs" });
        }


    }
}
