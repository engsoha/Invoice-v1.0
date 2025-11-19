using Egyptian_eInvoicing.Models;
using Egyptian_eInvoicing.Models.Lines;
using Microsoft.AspNetCore.Mvc.Rendering;
using Egyptian_eInvoicing.Models.Structures;

namespace Egyptian_eInvoicing.ViewModels
{
    public class InvoiceCreationViewModel
    {
        public Document InvoiceData { get; set; } = new Document();
        public List<InvoiceLineViewModel> Lines { get; set; } = new List<InvoiceLineViewModel> { new InvoiceLineViewModel() };
        public SelectList ActivityCodesList { get; set; }
        public SelectList CountryCodesList { get; set; }
        public SelectList TaxTypesList { get; set; }
        public SelectList UnitTypesList { get; set; }
        public Issuer IssuerInfo { get; set; }
    }
}
