using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace WebApplication1.Web.Filters
{
    public class LogFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            Debug.WriteLine("Action metot çalışmadan önce");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Debug.WriteLine("Action metot çalıştıktan sonra");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            Debug.WriteLine("Sonuç üretilmeden önce");
        }

        public override void OnResultExecuted(ResultExecutedContext context)
        {
            Debug.WriteLine("Sonuç üretildikten sonra");
        }
    }
}
