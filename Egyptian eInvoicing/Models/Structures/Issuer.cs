using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Issuer
    {
        [JsonPropertyName("type")]
        [Required(ErrorMessage ="Issuer type is required")]
        public string Type { get; set; }

        [JsonPropertyName("id")]
        [Required(ErrorMessage = "Issuer registration number is required")]
        public string Id { get; set; }
        
        [JsonPropertyName("name")]
        [Required(ErrorMessage = "Issuer name is required")]
        public string Name { get; set; }
        
        [JsonPropertyName("address")]
        [Required(ErrorMessage = "Issuer address is required")]
        public IssuerAddress Address { get; set; }
    }
}
