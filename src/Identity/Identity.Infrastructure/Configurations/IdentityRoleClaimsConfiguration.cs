using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Infrastructure.Configurations
{
    internal class IdentityRoleClaimsConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<Guid>> builder)
        {

        }
    }
}
