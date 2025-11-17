using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxTotal
    {
        [JsonProperty("taxType")]
        public string TaxType { get; set; }

        [JsonProperty("amount")]
        public decimal Amount { get; set; }

    }
}
