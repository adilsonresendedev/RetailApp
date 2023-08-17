using Newtonsoft.Json;
using RetailApp.ViewModels;
using System.Text;

namespace RetailApp.ApiClient
{
    public class ApiConnectionClient
    {
        private HttpClient _httpClient;
        private string _httpEncoding = "application/json";

        public ApiConnectionClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<ResponseViewModel<T>> PostAsync<T, TDataToSend>(string url, TDataToSend dataToSend)
        {
            ResponseViewModel<T> responseViewModel = new ResponseViewModel<T>();

            HttpContent httpContent = CreateHttpContet(dataToSend);
            using (HttpResponseMessage httpResponseMessage = await _httpClient.PostAsync(url, httpContent))
            {
                responseViewModel = await HandleResponse<T>(httpResponseMessage);
            }

            return responseViewModel;
        }

        private HttpContent CreateHttpContet<TDataToSend>(TDataToSend dataToSend)
        {
            string jsonContent = JsonConvert.SerializeObject(dataToSend, Formatting.Indented);
            StringContent stringContent = new StringContent(jsonContent, Encoding.UTF8, _httpEncoding);
            HttpContent httpContent = stringContent;
            return httpContent;
        }

        public async Task<ResponseViewModel<T>> HandleResponse<T>(HttpResponseMessage httpResponseMessage)
        {
            ResponseViewModel<T> responseViewModel = new ResponseViewModel<T>();
            responseViewModel.StatusCode = httpResponseMessage.StatusCode;
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using (HttpContent httpContentReturned = httpResponseMessage.Content)
                {
                    string returnContentString = await httpContentReturned.ReadAsStringAsync();
                    if (!string.IsNullOrWhiteSpace(returnContentString))
                    {
                        responseViewModel = JsonConvert.DeserializeObject<ResponseViewModel<T>>(returnContentString);
                    }
                }
            }
            else
            {
                responseViewModel.IsSuccess = false;
                responseViewModel.Message = httpResponseMessage.ReasonPhrase;
            }

            return responseViewModel;
        }
    }
}