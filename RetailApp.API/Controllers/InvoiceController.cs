using Microsoft.AspNetCore.Mvc;
using RetailApp.ViewModels.Fiscal;

namespace RetailApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetViewModelByXML()
        {
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel { SupplierViewModel = new ViewModels.Suplier.SupplierViewModel() };
            return Ok(invoiceViewModel);
        }
    }
}
