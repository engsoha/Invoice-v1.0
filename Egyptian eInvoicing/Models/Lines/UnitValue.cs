using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Lines
{
    public class UnitValue
    {
        [Required(ErrorMessage = "Currency sold code is required.")]
        public string CurrencySold { get; set; }

        [Required(ErrorMessage = "Unit value in EGP is required.")] 
        public decimal AmountEGP { get; set; }

        public decimal AmountSold { get; set; }

        public decimal CurrencyExchangeRate { get; set; }

    }
}
