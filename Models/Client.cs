using System.ComponentModel.DataAnnotations;

namespace Rumuel_Store_ASPN_CursoMod129.Models
{
    public class Client
    {
        public int ClientID { get; set; }

        [StringLength(255)]
        [Required]
        public string? Name { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime Birthday { get; set; }

        [StringLength(100)]
        [Required]
        public string? Address { get; set; }

        [StringLength(20)]
        [Required]
        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        [StringLength(50)]
        [Required]
        public string City { get; set; }

        [StringLength(255)]
        [Required]
        public string? NIF { get; set; }

        [StringLength(255)]
        [Display(Name = "Client Number")]
        public string Number { get; set; }

        [StringLength(255)]
        [Display(Name = "E-mail")]
        [Required]
        public string Email { get; set; }
    }
}
