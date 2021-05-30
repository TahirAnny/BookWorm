using System.ComponentModel.DataAnnotations;

namespace BookWorm.Models.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cover Type")]
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
