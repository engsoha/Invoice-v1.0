using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Egyptian_eInvoicing.Models.Structures
{
    public class IssuerAddress
    {
        [JsonProperty("branchId")]
        [Required(ErrorMessage = "Branch ID is required for the issuer.")]
        public string BranchId { get; set; }

        [JsonProperty("country")]
        [Required(ErrorMessage = "Country code is required.")]
        public string Country { get; set; }

        [JsonProperty("governorate")]
        [Required(ErrorMessage = "Governorate is required.")]
        public string Governorate { get; set; }

        [JsonProperty("regionCity")]
        [Required(ErrorMessage = "Region/City is required.")]
        public string RegionCity { get; set; }

        [JsonProperty("street")]
        [Required(ErrorMessage = "Street is required.")]
        public string Street { get; set; }

        [JsonProperty("buildingNumber")]
        [Required(ErrorMessage = "Building number is required.")]
        public string BuildingNumber { get; set; }
    
    }
}
