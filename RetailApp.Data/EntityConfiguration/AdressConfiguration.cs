using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using RetailApp.Entities;

namespace RetailApp.Data.EntityConfiguration
{
    internal class AdressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.IdAdress);

            //Adilson added some changes here;
        }
    }
}