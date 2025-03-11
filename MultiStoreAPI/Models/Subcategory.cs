using System.ComponentModel.DataAnnotations;

namespace MultiStoreAPI.Models
{
    public class Subcategory : BaseEntity
    {
        [MinLength(3)]
        [MaxLength(60)]
        public required string Name { get; set; }

        public int CategoryId { get; set; }

        //relations
        public Category? Category { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
