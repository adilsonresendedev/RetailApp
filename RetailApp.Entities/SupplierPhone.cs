using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class SupplierPhone : BaseEntity
    {
        public int IdSupplier { get; set; }
        public int IdPhone { get; set; }
        public virtual Phone Phone { get; set; }
    }
}
