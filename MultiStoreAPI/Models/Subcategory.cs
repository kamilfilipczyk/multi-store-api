using System.ComponentModel.DataAnnotations;

namespace MultiStoreAPI.Models
{
    public class Subcategory
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(60)]
        public required string Name { get; set; }

        public int CategoryId { get; set; }


        //relations
        public Category? Category { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
