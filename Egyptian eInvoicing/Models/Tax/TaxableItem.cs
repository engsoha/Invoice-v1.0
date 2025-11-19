using Egyptian_eInvoicing.Models.Lines;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxableItem
    {
        [Key]
        public int Id { get; set; }
         public int InvoiceLineId { get; set; }
        [ForeignKey("InvoiceLineId")]
        public InvoiceLine InvoiceLine { get; set; }

        [Required(ErrorMessage = "Tax type code is required.")]
        public string TaxType { get; set; }

        [Required(ErrorMessage = "Taxable amount is required.")] 
        public decimal Amount { get; set; }

        public string SubType { get; set; }

        [Range(0, 999, ErrorMessage = "Tax rate must be a valid percentage.")]
        public decimal Rate { get; set; }

    }
}
