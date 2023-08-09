using RetailApp.ViewModels;
using RetailApp.ViewModels.Fiscal;

namespace RetailApp.Services.Interfaces
{
    public interface IInvoiceService
    {
        ResponseViewModel<InvoiceViewModel> GetInvoiceViewModelByXML(string xml);
    }
}
