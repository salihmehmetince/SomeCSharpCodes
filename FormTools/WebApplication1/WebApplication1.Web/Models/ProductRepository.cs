using WebApplication1.Web.Models;

namespace WebApplication1.Web.Models
{
    public class ProductRepository
    {

        private static List<Product> _products=new List<Product>()
        {
             new() { Id=1,Name="asd",Type="dsa",Price=1000},
             new () { Id=2,Name="add",Type="dsa",Price=4000},
             new() { Id = 3, Name = "agd", Type = "ssa", Price = 4000 }
        };

        public List<Product> getProducts => _products;

        public void add(Product newProduct)
        {
            _products.Add(newProduct);
        }

        public void delete(int id)
        {
            var element=_products.FirstOrDefault(x=>x.Id==id);
            if(element==null)
            {
                throw new Exception("No record found which has id: ("+id+")");
            }

            _products.Remove(element);

        }

        public void update(Product updateProduct)
        {
            var element = _products.FirstOrDefault(x => x.Id == updateProduct.Id);
            if (element == null)
            {
                throw new Exception("No record found which has id: (" + updateProduct.Id + ")");
            }

            element.Name = updateProduct.Name;
            element.Type = updateProduct.Type;
            element.Price = updateProduct.Price;

            int index=_products.FindIndex(x=>x.Id==updateProduct.Id);
            _products[index]=updateProduct;
        }
    }
}
