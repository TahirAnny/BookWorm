using System.ComponentModel.DataAnnotations;

namespace BookWorm.Models.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Category Name")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
