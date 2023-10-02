using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class Phone : BaseEntity
    {
        public int IdPhone { get; set; }
        public bool MainPhone { get; set; }
        public string PhoneNumber { get; set; } = default!;
    }
}
