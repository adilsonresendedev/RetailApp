using System.ComponentModel.DataAnnotations;

namespace RetailApp.Entities
{
    public class User : BaseEntity
    {
        [Key]
        public int IdUser { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public byte[] PasswordHash { get; set; } = default!;
        public byte[] PasswordSalt { get; set; } = default!;
    }
}
