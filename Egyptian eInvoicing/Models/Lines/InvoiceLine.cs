using Egyptian_eInvoicing.Models.Tax;
using System.ComponentModel.DataAnnotations;

namespace Egyptian_eInvoicing.Models.Lines
{
    public class InvoiceLine
    {
        public int Id { get; set; }
        public int DocumentId { get; set; }
        public Document Document { get; set; }

        [Required(ErrorMessage = "Item description is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Item code type (GS1/EGS) is required.")]
        public string ItemType { get; set; }

        [Required(ErrorMessage = "Item code is required.")]
        public string ItemCode { get; set; }

        [Required(ErrorMessage = "Unit type code is required.")]
        public string UnitType { get; set; }

        [Required(ErrorMessage = "Quantity is required and must be greater than zero.")]
        [Range(0.00001, double.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public decimal Quantity { get; set; }

        public string InternalCode { get; set; }

        [Required(ErrorMessage = "Unit value structure is required.")]
        public UnitValue UnitValue { get; set; }

        public Discount Discount { get; set; }

        public List<TaxableItem> TaxableItems { get; set; }

        [Required(ErrorMessage = "Sales total is required.")]
        public decimal SalesTotal { get; set; }

        [Required(ErrorMessage = "Line total amount is required.")]
        public decimal Total { get; set; }

        public decimal ValueDifference { get; set; }

        public decimal TotalTaxableFees { get; set; }

        [Required(ErrorMessage = "Net total is required.")]
        public decimal NetTotal { get; set; }

        public decimal ItemsDiscount { get; set; }
    }
}
