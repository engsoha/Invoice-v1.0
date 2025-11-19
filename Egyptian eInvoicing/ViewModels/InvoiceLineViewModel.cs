using Egyptian_eInvoicing.Models.Lines;
using Egyptian_eInvoicing.Models.Tax;

namespace Egyptian_eInvoicing.ViewModels
{
    public class InvoiceLineViewModel
    {
        public InvoiceLine LineData { get; set; } = new InvoiceLine();
        public List<TaxableItem> TaxItems { get; set; } = new List<TaxableItem>();
    }
}
