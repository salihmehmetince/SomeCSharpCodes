using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Web.Models;
using WebApplication1.Web.Models.ViewModels;

namespace WebApplication1.Web.Views.Shared.ViewComponents
{
    public class VisitorViewComponent:ViewComponent
    {
        private readonly AppDBContext context;
        private readonly IMapper mapper;

        public VisitorViewComponent(AppDBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Visitor> visitors=context.Visitors.ToList();
            List<VisitorViewModel> visitorViewModels=mapper.Map<List<VisitorViewModel>>(visitors);
            VisitorContainerViewModel visitorContainerViewModel = new VisitorContainerViewModel() 
            {
                visitorViewModels = visitorViewModels,
                visitorViewModel=new VisitorViewModel()
            };
            return View(visitorContainerViewModel);
        }
    }
}
