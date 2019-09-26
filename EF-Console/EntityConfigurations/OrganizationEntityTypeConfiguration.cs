using EF_Console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Console.EntityConfigurations
{
    class OrganizationEntityTypeConfiguration : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.CreatedTime);

            builder.Metadata.FindNavigation(nameof(Organization.OwnAccounts)).SetPropertyAccessMode(PropertyAccessMode.Field);
            // DDD Patterns comment:
            //Set as field (New since EF 1.1) to access the OrderItem collection property through its field

        }
    }
}
