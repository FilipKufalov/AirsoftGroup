using System.ComponentModel.DataAnnotations;

namespace AirsoftGroup.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Display(Name ="Product Name")]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
    }
}
