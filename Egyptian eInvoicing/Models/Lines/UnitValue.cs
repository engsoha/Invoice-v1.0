using System.ComponentModel.DataAnnotations;
namespace Egyptian_eInvoicing.Models.Lines
{
    public class UnitValue
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceLineId { get; set; }
        public InvoiceLine InvoiceLine { get; set; }

        [Required(ErrorMessage = "Currency sold code is required.")]
        public string CurrencySold { get; set; }

        [Required(ErrorMessage = "Unit value in EGP is required.")] 
        public decimal AmountEGP { get; set; }

        public decimal AmountSold { get; set; }

        public decimal CurrencyExchangeRate { get; set; }

    }
}
