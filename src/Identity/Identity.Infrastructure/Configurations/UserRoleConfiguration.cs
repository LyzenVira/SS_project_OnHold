using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Identity.Infrastructure.Configurations
{
    internal class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(new List<IdentityUserRole<Guid>>()
            {
                new()
                {
                    RoleId = Guid.Parse("d522e6ae-a0d5-4753-8bf1-feb30e3b575e"),
                    UserId = Guid.Parse("672979c9-d851-4bb7-83b6-a75e906dbefa"),
                },
                new()
                {
                    RoleId = Guid.Parse("d522e6ae-a0d5-4753-8bf1-feb30e3b575e"),
                    UserId = Guid.Parse("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                },
                new()
                {
                    RoleId = Guid.Parse("7a7231fb-fe42-40df-bf8b-1adcb564a135"),
                    UserId = Guid.Parse("537826d9-90b5-4d70-9606-addbd078d509")
                }
            });
        }
    }
}
