using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RetailApp.Entities;

namespace RetailApp.Data.EntityConfiguration
{
    internal class SupplierPhoneConfiguration : IEntityTypeConfiguration<SupplierPhone>
    {
        public void Configure(EntityTypeBuilder<SupplierPhone> builder)
        {
            builder.HasKey(x => new { x.IdSupplier, x.IdPhone });
        }
    }
}