using Egyptian_eInvoicing.Models.Lines;
using Egyptian_eInvoicing.Models.Structures;
using Egyptian_eInvoicing.Models.Tax;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Egyptian_eInvoicing.Models
{
    public class Document
    {

        [Required(ErrorMessage = "Issuer data is required.")]
        public Issuer Issuer { get; set; }

        [Required(ErrorMessage = "Receiver data is required.")]
        public Receiver Receiver { get; set; }
        
        [Required]
        public string DocumentType { get; set; } = "i";
     
        [Required(ErrorMessage = "Document type is required.")]
        public string DocumentTypeVersion { get; set; } = "1.0";
        
        [Required(ErrorMessage = "Document version is required.")]
        public DateTime DateTimeIssued { get; set; }
        
        [Required(ErrorMessage = "Taxpayer activity code is required.")]
        public string TaxpayerActivityCode { get; set; }
        
        [Required(ErrorMessage = "Internal document ID is required.")]
        public string InternalId { get; set; }
        
        [Required(ErrorMessage = "The invoice must have at least one line item.")]
        public List<InvoiceLine> InvoiceLines { get; set; }
        
        [Required(ErrorMessage = "Total sales amount is required.")]
        public decimal TotalSalesAmount { get; set; }
        
        [Required(ErrorMessage = "Total discount amount is required.")] 
        public decimal TotalDiscountAmount { get; set; }
        
        [Required(ErrorMessage = "Net amount is required.")]
        public decimal NetAmount { get; set; }
        
        public List<TaxTotal> TaxTotals { get; set; }
        
        public decimal ExtraDiscountAmount { get; set; }
        
        public decimal TotalItemsDiscountAmount { get; set; }
        
        [Required(ErrorMessage = "Total invoice amount is required.")]
        public decimal TotalAmount { get; set; }

    }
}
