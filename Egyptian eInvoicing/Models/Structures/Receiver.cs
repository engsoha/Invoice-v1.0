using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Structures
{
    public class Receiver
    {
        [JsonProperty("type")]
        [Required(ErrorMessage = "Receiver type is required.")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public ReceiverAddress Address { get; set; }
    
    }
}
