using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RetailApp.Entities;

namespace RetailApp.Data.EntityConfiguration
{
    internal class SupplierAdressConfiguration : IEntityTypeConfiguration<SupplierAdress>
    {
        public void Configure(EntityTypeBuilder<SupplierAdress> builder)
        {
            builder.HasKey(x => new {x.IdSupplier, x.IdAdress});
        }
    }
}
