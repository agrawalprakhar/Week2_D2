using System.ComponentModel.DataAnnotations;

namespace Week_2_Day_2.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(50, ErrorMessage = "Product name must be between {2} and {1} characters.", MinimumLength = 2)]
        public string Name { get; set; }
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
    }
}
