namespace WebApplication1.Web.Models
{
    public class ProductRepository
    {

        private static List<Product> _products=new List<Product>();

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
