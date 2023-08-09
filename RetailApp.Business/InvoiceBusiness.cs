using RetailApp.Business.Interfaces;
using RetailApp.Utility;
using RetailApp.ViewModels.Address;
using RetailApp.ViewModels.Fiscal;
using RetailApp.ViewModels.Phone;
using RetailApp.ViewModels.Suplier;
using System.Text;

namespace RetailApp.Business
{
    public class InvoiceBusiness : IInvoiceBusiness
    {
        public InvoiceViewModel GetInvoiceViewModelByXML(string xml)
        {
            byte[] xmlByte = Convert.FromBase64String(xml);
            string xmlString = Encoding.UTF8.GetString(xmlByte);
            nfeProc nfeProc = XmlUtility.XmlToClass<nfeProc>(xmlString);
            InvoiceViewModel invoiceViewModel = new InvoiceViewModel
            {
                SupplierViewModel = new SupplierViewModel
                {
                    CNPJ = nfeProc.NFe.infNFe.emit.CNPJ,
                    Name = nfeProc.NFe.infNFe.emit.xNome,
                    ComercialName = nfeProc.NFe.infNFe.emit.xNome,
                    IE = nfeProc.NFe.infNFe.emit.IE,
                    IEST = nfeProc.NFe.infNFe.emit.IEST,
                    CRT = nfeProc.NFe.infNFe.emit.CRT,
                    addresViewModel = new List<AddresViewModel>
                    {
                        new AddresViewModel
                        {
                            MainAdress = true,
                            StreetName = nfeProc.NFe.infNFe.emit.enderEmit.xLgr,
                            StreetNumber = nfeProc.NFe.infNFe.emit.enderEmit.nro,
                            StreetAditionalInformation = nfeProc.NFe.infNFe.emit.enderEmit.xCpl,
                            Neighborhood = nfeProc.NFe.infNFe.emit.enderEmit.xBairro,
                            ZipCode = nfeProc.NFe.infNFe.emit.enderEmit.CEP
                        }
                    },
                    PhoneViewModel = new List<PhoneViewModel>
                    {
                        new PhoneViewModel
                        {
                            MainPhone = true,
                            PhoneNumber = nfeProc.NFe.infNFe.emit.enderEmit.fone
                        }
                    }
                }
            };

            return invoiceViewModel;
        }
    }
}