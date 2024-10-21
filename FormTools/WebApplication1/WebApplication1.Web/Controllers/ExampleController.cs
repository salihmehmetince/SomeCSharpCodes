using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Web.Controllers
{
    public class ExampleController : Controller
    {
        //index action metodu çalıştığında view yani html sayfası döndürür bunu yapabilmek için
        //cshtml sayfasının oluşturulmuş olması gerekir.
        //baseURL+controllerName+actionMethod
        public IActionResult Index()
        {
            ViewBag.name = "asddasda";
            ViewBag.number = 123;
            ViewBag.grades=new List<int>(new int[] { 100, 20, 30 });
            ViewData["name2"] = "sdfjshjdf";
            ViewData["numbers2"]=new List<int>(new int[] { 433,4343,434});
            ViewData["Note2"] = "Warninnnnnnnnngg:)";
            return View();
            //view dışında farklı dönüş tipleri de vardır.
            //bunlara örnek olarak:
            //content string döndürmek için
            //json json nesnesi döndürmek için
            //empty hiç bir şey döndürmemek için örnek verilebilir.
        }

        public IActionResult Index2(int id)
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
