namespace WebApplication1.Web.Models.ViewModels
{
    public class ProductListComponentViewModel
    {
        public List<ProductComponenViewModel> productsList { get; set; }
    }

    public class ProductComponenViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
