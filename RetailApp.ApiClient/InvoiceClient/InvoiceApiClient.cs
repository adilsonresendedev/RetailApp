using RetailApp.ViewModels;
using RetailApp.ViewModels.Fiscal;

namespace RetailApp.ApiClient.InvoiceClient
{
    public class InvoiceApiClient
    {
        public async Task<ResponseViewModel<InvoiceViewModel>> GetByXml(string base64String)
        {
            string url = "http://localhost:5131/api/Invoice/get-view-model-by-xml";
            ApiConnectionClient apiConnectionClient = new ApiConnectionClient();
            RequestViewModel<string> requestViewModel = new RequestViewModel<string>();
            requestViewModel.Data = base64String;
            ResponseViewModel<InvoiceViewModel> responseViewModel = await apiConnectionClient.PostAsync<InvoiceViewModel, RequestViewModel<string>>(url, requestViewModel);
            return responseViewModel;
        }
    }
}
