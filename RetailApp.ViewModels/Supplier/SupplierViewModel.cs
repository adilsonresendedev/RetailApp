using RetailApp.ViewModels.Address;
using RetailApp.ViewModels.Phone;
using System.Collections.Generic;

namespace RetailApp.ViewModels.Suplier
{
    public class SupplierViewModel
    {
        public int IdSuplier { get; set; }
        public string CNPJ { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ComercialName { get; set; } = default!;
        public string IE { get; set; } = default!;
        public string IEST { get; set; } = default!;
        public int CRT { get; set; }
        public List<AddresViewModel> addresViewModel { get; set; } = default!;
        public List<PhoneViewModel> PhoneViewModel { get; set; } = default!;
    }
}
