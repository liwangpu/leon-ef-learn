using EF_Console.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF_Console.EntityConfigurations
{
    class AccountTagEntityTypeConfiguration : IEntityTypeConfiguration<AccountTag>
    {
        public void Configure(EntityTypeBuilder<AccountTag> builder)
        {
            builder.HasKey(x => new { x.AccountId, x.TagId });
            builder.HasOne(x => x.Account).WithMany(a => a.OwnAccountTags).HasForeignKey(x => x.AccountId);
            builder.HasOne(x => x.Tag).WithMany(t => t.OwnAccountTags).HasForeignKey(x => x.TagId);
        }
    }
}
