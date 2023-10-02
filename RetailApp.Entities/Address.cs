using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class Address : BaseEntity
    {
        public int IdAdress { get; set; }
        public bool MainAdress { get; set; }
        public string StreetName { get; set; } = default!;
        public string StreetNumber { get; set; } = default!;
        public string StreetAditionalInformation { get; set; } = default!;
        public string Neighborhood { get; set; } = default!;
        public string ZipCode { get; set; } = default!;
        public string City { get; set; } = default!;
    }
}
