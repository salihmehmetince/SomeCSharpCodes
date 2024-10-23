namespace WebApplication1.Web.Models
{
    public class Product
    {
        private int id;
        private string name;
        private string type;
        private decimal price;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
