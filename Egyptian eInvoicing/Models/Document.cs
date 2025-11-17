using Egyptian_eInvoicing.Models.Lines;
using Egyptian_eInvoicing.Models.Structures;
using Egyptian_eInvoicing.Models.Tax;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Egyptian_eInvoicing.Models
{
    public class Document
    {

        [JsonProperty("issuer")]
        [Required(ErrorMessage = "Issuer data is required.")]
        public Issuer Issuer { get; set; }

        [JsonProperty("receiver")]
        [Required(ErrorMessage = "Receiver data is required.")]
        public Receiver Receiver { get; set; }
        
        [JsonProperty("documentType")]
        [Required]
        public string DocumentType { get; set; } = "i";
     
        [JsonProperty("documentTypeVersion")]
        [Required(ErrorMessage = "Document type is required.")]
        public string DocumentTypeVersion { get; set; } = "1.0";
        
        [JsonProperty("dateTimeIssued")]
        [Required(ErrorMessage = "Document version is required.")]
        public DateTime DateTimeIssued { get; set; }
        
        [JsonProperty("taxpayerActivityCode")]
        [Required(ErrorMessage = "Taxpayer activity code is required.")]
        public string TaxpayerActivityCode { get; set; }
        
        [JsonProperty("internalId")]
        [Required(ErrorMessage = "Internal document ID is required.")]
        public string InternalId { get; set; }
        
        [JsonProperty("invoiceLines")]
        [Required(ErrorMessage = "The invoice must have at least one line item.")]
        public List<InvoiceLine> InvoiceLines { get; set; }
        
        [JsonProperty("totalSalesAmount")]
        [Required(ErrorMessage = "Total sales amount is required.")]
        public decimal TotalSalesAmount { get; set; }
        
        [JsonProperty("totalDiscountAmount")]
        [Required(ErrorMessage = "Total discount amount is required.")] 
        public decimal TotalDiscountAmount { get; set; }
        
        [JsonProperty("netAmount")]
        [Required(ErrorMessage = "Net amount is required.")]
        public decimal NetAmount { get; set; }
        
        [JsonProperty("taxTotals")] 
        public List<TaxTotal> TaxTotals { get; set; }
        
        [JsonProperty("extraDiscountAmount")] 
        public decimal ExtraDiscountAmount { get; set; }
        
        [JsonProperty("totalItemsDiscountAmount")] 
        public decimal TotalItemsDiscountAmount { get; set; }
        
        [JsonProperty("totalAmount")]
        [Required(ErrorMessage = "Total invoice amount is required.")]
        public decimal TotalAmount { get; set; }

    }
}
