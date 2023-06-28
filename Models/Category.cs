using System.ComponentModel.DataAnnotations;

namespace Rumuel_Store_ASPN_CursoMod129.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [StringLength(100)]
        [Required]
        public string? Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Description { get; set; } 
    }
}
