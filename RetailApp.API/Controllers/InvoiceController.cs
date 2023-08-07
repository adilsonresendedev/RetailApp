using Microsoft.AspNetCore.Mvc;
using RetailApp.Services;
using RetailApp.Services.Interfaces;
using RetailApp.ViewModels.Fiscal;
using System.Xml;

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

        [HttpGet]
        public async Task<IActionResult> GetViewModelByXML()
        {
            XmlDocument xmlDocument = new XmlDocument();
            InvoiceViewModel invoiceViewModel = _invoiceService.GetInvoiceViewModelByXML(xmlDocument.OuterXml);
            return Ok(invoiceViewModel);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetViewModelByXML([FromBody] XmlDocument xmlDocument)
        //{
        //    InvoiceViewModel invoiceViewModel = _invoiceService.GetInvoiceViewModelByXML(xmlDocument.OuterXml);
        //    return Ok(invoiceViewModel);
        //}
    }
}
