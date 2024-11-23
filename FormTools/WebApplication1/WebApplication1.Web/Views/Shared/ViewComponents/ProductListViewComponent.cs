using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.Models;
using WebApplication1.Web.Models.ViewModels;

namespace WebApplication1.Web.Views.Shared.ViewComponents
{
    public class ProductListViewComponent:ViewComponent
    {
        private readonly AppDBContext appDBContext;

        public ProductListViewComponent(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int type)
        {
            var products = appDBContext.Products.Select(x => new ProductComponenViewModel() { Id = x.Id, Name = x.Name, Description = x.Description }).ToList() ;
            var productListViewComponent = new ProductListComponentViewModel() { productsList = products };
            if(type == 1)
            {
                return View("Default",productListViewComponent);

            }
            else if(type == 2)
            {
                return View("Type2",productListViewComponent);
            }
            else
            {
                return View("Default", productListViewComponent);
            }
        }
    }


}
