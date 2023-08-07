using RetailApp.Business.Interfaces;
using RetailApp.ViewModels.Fiscal;
using RetailApp.ViewModels.Suplier;

namespace RetailApp.Business
{
    public class InvoiceBusiness : IInvoiceBusiness
    {
        public InvoiceViewModel GetInvoiceViewModelByXML(string xml)
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel();
            invoiceViewModel.SupplierViewModel = new SupplierViewModel
            {
                Name = "Chegou na camada de business!"
            };

            return invoiceViewModel;
        }
    }
}