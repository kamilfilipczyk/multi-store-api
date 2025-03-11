using System.ComponentModel.DataAnnotations;

namespace MultiStoreAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [MinLength(3)]
        [MaxLength(60)]
        public required string Name { get; set; }


        //relations
        public ICollection<Subcategory>? Subcategories { get; set; }
    }
}
