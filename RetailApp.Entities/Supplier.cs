namespace RetailApp.Entities
{
    public class Supplier
    {
        public int IdSupplier { get; set; }
        public string CNPJ { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string ComercialName { get; set; } = default!;
        public string IE { get; set; } = default!;
        public string IEST { get; set; } = default!;
        public int CRT { get; set; }
        public virtual List<SupplierAdress> SupplierAdresses { get; set; }
        public virtual List<SupplierPhone> SuppliersPhones { get; set;}
    }
}