using System.Xml.Serialization;

namespace RetailApp.ViewModels.Fiscal
{
    [XmlRoot(Namespace = "http://www.portalfiscal.inf.br/nfe")]
    public class nfeProc
    {
        public NFe NFe { get; set; } = default!;
    }
}