using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
namespace Egyptian_eInvoicing.Models.Lines
{
    public class Discount
    {
        [Range(0, 100, ErrorMessage = "Discount rate must be between 0 and 100.")]
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "Unit value in EGP is required.")] 
        public decimal Amount { get; set; }
    }
}
