using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxableItem
    {
        [JsonProperty("taxType")]
        [Required(ErrorMessage = "Tax type code is required.")]
        public string TaxType { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("subType")]
        public string SubType { get; set; }

        [JsonProperty("rate")]
        [Range(0, 999, ErrorMessage = "Tax rate must be a valid percentage.")]
        public decimal Rate { get; set; }

    }
}
