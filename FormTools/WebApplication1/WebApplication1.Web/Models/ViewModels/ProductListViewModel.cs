namespace WebApplication1.Web.Models.ViewModels
{
    public class ProductListViewModel
    {
        public List<ProductPartialViewModel> products { get; set; }
    }

    public class ProductPartialViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
