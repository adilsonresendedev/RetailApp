using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class SupplierAdress : BaseEntity
    {
        public int IdSupplierAdress { get; set; }
        public int IdSupplier { get; set; }
        public int IdAdress { get; set; }
        public virtual Address Address { get; set; }
    }
}