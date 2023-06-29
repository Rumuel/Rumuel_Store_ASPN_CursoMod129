using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Rumuel_Store_ASPN_CursoMod129.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [StringLength(100)]
        [Required]
        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public decimal Stock { get; set; }

        public decimal Weight { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [ValidateNever]
        public Category? Category { get; set; }
    }
}
