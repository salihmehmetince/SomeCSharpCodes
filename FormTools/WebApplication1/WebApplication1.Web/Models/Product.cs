using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Web.Models
{
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pName")]
        public string Name { get; set; }

        [Column("pType")]
        public string Type { get; set; }

        [Column("pPrice")]
        public decimal Price { get; set; }

        [Column("color")]
        public string? Color { get; set; }

        [Column("height")]
        public int? Height { get; set; }

        [Column("width")]
        public int? Width { get; set; }

        [Column("stock")]
        public int? stock { get; set; }

        [Column("piece")]
        public int? piece { get; set; }

        [Column("description")]
        public string? Description { get; set; }

        [Column("isShow")]
        public bool IsShow { get; set; }

        [Column("Expiration")]
        public int Expiration { get; set; }


    }
}
