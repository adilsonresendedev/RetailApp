using RetailApp.Business.Interfaces;
using RetailApp.Services.Interfaces;
using RetailApp.ViewModels.Fiscal;

namespace RetailApp.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceBusiness _invoiceBusiness;
        public InvoiceService(IInvoiceBusiness invoiceBusiness)
        {
            _invoiceBusiness = invoiceBusiness;
        }
        public InvoiceViewModel GetInvoiceViewModelByXML(string xml)
        {
            InvoiceViewModel invoiceViewModel = _invoiceBusiness.GetInvoiceViewModelByXML(xml);
            return invoiceViewModel;
        }
    }
}