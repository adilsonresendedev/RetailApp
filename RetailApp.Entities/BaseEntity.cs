namespace RetailApp.Entities
{
    public class BaseEntity
    {
        public bool IsActive { get; set; }
        public int? IdUser { get; set; }
        public DateTime AddedAt { get; set; }    
        public DateTime? UpdatedAt {  get; set; }
    }
}
