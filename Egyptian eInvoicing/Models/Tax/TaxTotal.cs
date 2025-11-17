using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxTotal
    {
        [Required(ErrorMessage = "Tax type code is required.")]
        public string TaxType { get; set; }

        [Required(ErrorMessage = "Taxable amount is required.")]
        public decimal Amount { get; set; }

    }
}
