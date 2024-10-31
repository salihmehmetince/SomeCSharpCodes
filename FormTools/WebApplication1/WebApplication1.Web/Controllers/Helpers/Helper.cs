namespace WebApplication1.Web.Controllers.Helpers
{
    public class Helper : IHelper
    {
        public string Upper(string text)
        {
            return text.ToUpper();
        }
    }
}
