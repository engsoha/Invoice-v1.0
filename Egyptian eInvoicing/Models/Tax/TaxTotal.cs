using System.ComponentModel.DataAnnotations;
namespace Egyptian_eInvoicing.Models.Tax
{
    public class TaxTotal
    {
        [Key]
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }

        [Required(ErrorMessage = "Tax type code is required.")]
        public string TaxType { get; set; }

        [Required(ErrorMessage = "Taxable amount is required.")]
        public decimal Amount { get; set; }

    }
}
