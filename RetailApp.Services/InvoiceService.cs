using RetailApp.Business.Interfaces;
using RetailApp.Services.Interfaces;
using RetailApp.ViewModels;
using RetailApp.ViewModels.Fiscal;
using System.Net;

namespace RetailApp.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceBusiness _invoiceBusiness;
        public InvoiceService(IInvoiceBusiness invoiceBusiness)
        {
            _invoiceBusiness = invoiceBusiness;
        }

        public ResponseViewModel<InvoiceViewModel> GetInvoiceViewModelByXML(string xml)
        {
            ResponseViewModel<InvoiceViewModel> responseViewModel = new ResponseViewModel<InvoiceViewModel>(HttpStatusCode.OK);
            try
            {
                InvoiceViewModel invoiceViewModel = _invoiceBusiness.GetInvoiceViewModelByXML(xml);
                responseViewModel.Data = invoiceViewModel;
            }
            catch (Exception ex)
            {
                responseViewModel = new ResponseViewModel<InvoiceViewModel>(ex);
            }

            return responseViewModel;
        }
    }
}