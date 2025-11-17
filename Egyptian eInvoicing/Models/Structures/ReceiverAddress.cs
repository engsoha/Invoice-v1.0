using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class ReceiverAddress
    {
        [Required(ErrorMessage = "Country code is required.")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Governorate is required.")]
        public string Governorate { get; set; }

        [Required(ErrorMessage = "Region/City is required.")]
        public string RegionCity { get; set; }

        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Building number is required.")]
        public string BuildingNumber { get; set; }
    
    }
}
