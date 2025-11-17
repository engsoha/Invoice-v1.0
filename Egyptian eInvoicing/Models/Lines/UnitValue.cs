using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Lines
{
    public class UnitValue
    {
        [JsonProperty("currencySold")]
        [Required(ErrorMessage = "Currency sold code is required.")]
        public string CurrencySold { get; set; }

        [JsonProperty("amountEGP")]
        public decimal AmountEGP { get; set; }

        [JsonProperty("amountSold")]
        public decimal AmountSold { get; set; }

        [JsonProperty("currencyExchangeRate")]
        public decimal CurrencyExchangeRate { get; set; }

    }
}
