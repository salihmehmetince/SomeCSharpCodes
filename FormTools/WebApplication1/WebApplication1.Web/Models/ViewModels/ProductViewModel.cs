using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Web.Models.ViewModels
{
    public class ProductViewModel
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("pName")]
        [Required(ErrorMessage = "Name cannot be empty")]
        [StringLength(100,MinimumLength =2,ErrorMessage ="name length must be between 2-100")]
        public string Name { get; set; }

        [Column("pType")]
        [StringLength(100,MinimumLength =3,ErrorMessage ="Type lenght must be between 3-100")]
        [Required(ErrorMessage ="Type cannot be empty")]
        public string Type { get; set; }

        [Column("pPrice")]
        [Required(ErrorMessage ="Price cannot be empty")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})?$", ErrorMessage = "The price field must have at most 2 decimal places.")]
        public decimal? Price { get; set; }

        [Column("color")]
        [Required(ErrorMessage ="Color cannot be empty")]
        public string? Color { get; set; }

        [Column("height")]
        [Required(ErrorMessage ="Height cannot be empty")]
        [Range(1,1000,ErrorMessage ="Height must be between 1-1000")]
        public int? Height { get; set; }

        [Column("width")]
        [Required(ErrorMessage ="Width cannot be empty")]
        [Range(1,1000,ErrorMessage ="Width must be between 1-1000")]
        public int? Width { get; set; }

        [Column("stock")]
        //[Required(ErrorMessage ="Stock cannot be empty")]
        public int? stock { get; set; }

        [Column("piece")]
        //[Required(ErrorMessage = "Piece cannot be empty")]

        public int? piece { get; set; }

        [Column("description")]
        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description { get; set; }

        [Column("isShow")]
        public bool IsShow { get; set; }

        [Column("Expiration")]
        [Required(ErrorMessage = "Expiration cannot be empty")]
        public int? Expiration { get; set; }

        [Column("removeDate")]
        [Required(ErrorMessage = "Remove date cannot be empty")]
        public DateTime? RemoveDate { get; set; }
    }
}
