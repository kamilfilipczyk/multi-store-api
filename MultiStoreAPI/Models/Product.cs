using System.ComponentModel.DataAnnotations;

namespace MultiStoreAPI.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [MinLength(5)]
        [MaxLength(150)]
        public required string Name { get; set; }

        public required decimal Price { get; set; }

        public int StockValue { get; set; }

        [MinLength(5)]
        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public float Rating { get; set; } = 0;

        public int SubcategoryId { get; set; }


        //relations
        public Subcategory? Subcategory { get; set; }
    }
}
