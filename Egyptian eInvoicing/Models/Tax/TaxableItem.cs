using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxableItem
    {
        [Required(ErrorMessage = "Tax type code is required.")]
        public string TaxType { get; set; }

        [Required(ErrorMessage = "Taxable amount is required.")] 
        public decimal Amount { get; set; }

        public string SubType { get; set; }

        [Range(0, 999, ErrorMessage = "Tax rate must be a valid percentage.")]
        public decimal Rate { get; set; }

    }
}
