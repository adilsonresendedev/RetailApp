using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class Supplier : BaseEntity
    {
        public int IdSupplier { get; set; }
        public string CNPJ { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ComercialName { get; set; } = default!;
        public string IE { get; set; } = default!;
        public string IEST { get; set; } = default!;
        public int? CRT { get; set; }
        public List<SupplierAdress> SupplierAdresses { get; set; } = default!;
        public List<SupplierPhone> SupplierPhones { get; set; } = default!;
    }
}