using Egyptian_eInvoicing.Models.Tax;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using Newtonsoft.Json;

namespace Egyptian_eInvoicing.Models.Lines
{
    public class InvoiceLine
    {
        [JsonProperty("description")]
        [Required(ErrorMessage = "Item description is required.")]
        public string Description { get; set; }

        [JsonProperty("itemType")]
        [Required(ErrorMessage = "Item code type (GS1/EGS) is required.")]
        public string ItemType { get; set; }

        [JsonProperty("itemCode")]
        [Required(ErrorMessage = "Item code is required.")]
        public string ItemCode { get; set; }

        [JsonProperty("unitType")]
        [Required(ErrorMessage = "Unit type code is required.")]
        public string UnitType { get; set; }

        [JsonProperty("quantity")]
        [Required(ErrorMessage = "Quantity is required and must be greater than zero.")]
        [Range(0.00001, double.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public decimal Quantity { get; set; }

        [JsonProperty("internalCode")]
        public string InternalCode { get; set; }

        [JsonProperty("unitValue")]
        [Required(ErrorMessage = "Unit value structure is required.")]
        public UnitValue UnitValue { get; set; }

        [JsonProperty("discount")]
        public Discount Discount { get; set; }

        [JsonProperty("taxableItems")]
        public List<TaxableItem> TaxableItems { get; set; }

        // Totals
        [JsonProperty("salesTotal")]
        [Required(ErrorMessage = "Sales total is required.")]
        public decimal SalesTotal { get; set; }

        [JsonProperty("total")]
        [Required(ErrorMessage = "Line total amount is required.")]
        public decimal Total { get; set; }

        [JsonProperty("valueDifference")]
        public decimal ValueDifference { get; set; }

        [JsonProperty("totalTaxableFees")]
        public decimal TotalTaxableFees { get; set; }

        [JsonProperty("netTotal")]
        [Required(ErrorMessage = "Net total is required.")]
        public decimal NetTotal { get; set; }

        [JsonProperty("itemsDiscount")]
        public decimal ItemsDiscount { get; set; }
    }
}
