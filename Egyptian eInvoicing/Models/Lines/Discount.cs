using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Egyptian_eInvoicing.Models.Lines
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        public int InvoiceLineId { get; set; }
        [ForeignKey("InvoiceLineId")]
        public InvoiceLine InvoiceLine { get; set; }

        [Range(0, 100, ErrorMessage = "Discount rate must be between 0 and 100.")]
        public decimal Rate { get; set; }

        [Required(ErrorMessage = "Unit value in EGP is required.")] 
        public decimal Amount { get; set; }
    }
}
