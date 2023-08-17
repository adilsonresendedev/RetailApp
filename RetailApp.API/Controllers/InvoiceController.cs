using Microsoft.AspNetCore.Mvc;
using RetailApp.Services.Interfaces;
using RetailApp.ViewModels;
using RetailApp.ViewModels.Fiscal;

namespace RetailApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        [HttpPost]
        [Route("get-view-model-by-xml")]
        [ProducesResponseType(typeof(ResponseViewModel<InvoiceViewModel>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseViewModel<InvoiceViewModel>), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetViewModelByXML([FromBody] RequestViewModel<string> requestViewModel)
        {
            ResponseViewModel<InvoiceViewModel> responseViewModel = _invoiceService.GetInvoiceViewModelByXML(requestViewModel.Data);
            return StatusCode((int)responseViewModel.StatusCode, responseViewModel);
        }
    }
}
