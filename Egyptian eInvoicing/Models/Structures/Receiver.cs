using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Receiver
    {
        [Required(ErrorMessage = "Receiver type is required.")]
        public string Type { get; set; }

        [Required(ErrorMessage = "Issuer registration number is required")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Issuer name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Issuer address is required")]
        public ReceiverAddress Address { get; set; }
    
    }
}
