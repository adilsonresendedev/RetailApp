using RetailApp.ViewModels.Fiscal;

namespace RetailApp.Services.Interfaces
{
    public interface IInvoiceService
    {
        InvoiceViewModel GetInvoiceViewModelByXML(string xml);
    }
}
