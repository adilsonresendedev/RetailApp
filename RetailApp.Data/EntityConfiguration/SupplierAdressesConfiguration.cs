using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RetailApp.Entities;

namespace RetailApp.Data.EntityConfiguration
{
    internal class SupplierAdressesConfiguration : IEntityTypeConfiguration<SupplierAdress>
    {
        public void Configure(EntityTypeBuilder<SupplierAdress> builder)
        {
            builder.HasKey(x => new {x.IdSupplier, x.IdAdress});
        }
    }
}