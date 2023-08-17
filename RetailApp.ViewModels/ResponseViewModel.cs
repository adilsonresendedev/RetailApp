using System;
using System.Net;

namespace RetailApp.ViewModels
{
    public class ResponseViewModel<T>
    {
        public ResponseViewModel()
        {
            
        }
        public ResponseViewModel(HttpStatusCode httpStatusCode)
        {
            IsSuccess = true;
            StatusCode = httpStatusCode;
        }

        public ResponseViewModel(Exception ex)
        {
            StatusCode = HttpStatusCode.InternalServerError;
            IsSuccess = false;
            Message = ex.GetBaseException().Message;
        }

        public HttpStatusCode StatusCode { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
