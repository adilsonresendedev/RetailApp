using RetailApp.ViewModels.Fiscal;

namespace RetailApp.Business.Interfaces
{
    public interface IInvoiceBusiness
    {
        InvoiceViewModel GetInvoiceViewModelByXML(string xml);
    }
}
