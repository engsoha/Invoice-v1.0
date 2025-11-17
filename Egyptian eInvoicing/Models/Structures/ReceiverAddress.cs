using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class ReceiverAddress
    {
        [JsonProperty("country")]
        [Required(ErrorMessage = "Country code is required.")]
        public string Country { get; set; }

        [JsonProperty("governorate")]
        public string Governorate { get; set; }

        [JsonProperty("regionCity")]
        public string RegionCity { get; set; }

        [JsonProperty("street")]
        public string Street { get; set; }

        [JsonProperty("buildingNumber")]
        public string BuildingNumber { get; set; }
    
    }
}
