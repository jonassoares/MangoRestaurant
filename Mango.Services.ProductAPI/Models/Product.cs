using System.ComponentModel.DataAnnotations;

namespace Mango.Services.ProductAPI.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Range(1, 1000)]
        public double Price { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }

        public Product(int productId, string name, double price, string description, string categoryName, string imageUrl)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            Description = description;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }
    }
}
