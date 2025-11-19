using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Issuer
    {
        [Key]
        public int Id { get; set; } 

        [Required(ErrorMessage = "Issuer registration number is required")]
        public string RegistrationId { get; set; }
      
        public  ICollection< Document> Document { get; set; }

        [Required(ErrorMessage ="Issuer type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Issuer name is required")]
        public string Name { get; set; }
        public int AddressId { get; set; }

        [Required(ErrorMessage = "Issuer address is required")]
        public IssuerAddress Address { get; set; }
    }
}
