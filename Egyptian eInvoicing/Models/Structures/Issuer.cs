using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Issuer
    {
        [Required(ErrorMessage ="Issuer type is required")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Issuer registration number is required")]
        public string Id { get; set; }
        
        [Required(ErrorMessage = "Issuer name is required")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Issuer address is required")]
        public IssuerAddress Address { get; set; }
    }
}
