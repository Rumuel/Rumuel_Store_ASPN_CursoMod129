using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace Rumuel_Store_ASPN_CursoMod129.Models
{
    public class Sale
    {
        public int ID { get; set; }

        [Display(Name = "Sales Number")]
        [Required]
        public string? Number { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [Required]
        public DateTime Time { get; set; }

        [Required]
        [Display(Name = "Client")]
        public int ClientID { get; set; }

        [ValidateNever]
        public Client? Client { get; set; }

        [Required]
        [Display(Name = "Products Sold")]
        public int ProductID { get; set; }

        [ValidateNever]
        public Product? Product { get; set; }

        [Display(Name = "Comments")]
        
        public string? Comments { get; set; }

        public decimal value { get; set; }

        //[Required]
        //[Display(Name = "Status")]
        //public int StatusID { get; set; }

        //[ValidateNever]
        //public Status? Status { get; set; }

        public StatusList? status { get; set; }
    }
}
