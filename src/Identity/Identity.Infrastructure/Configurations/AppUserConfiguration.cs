using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Infrastructure.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUser");

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();

            builder.HasData(new AppUser()
            {
                Id = Guid.Parse("537826d9-90b5-4d70-9606-addbd078d509"),
                UserName = "Mike",
                Email = "mike.goloborodko@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                PasswordHash = hasher.HashPassword(null, "User_1"),
            });
        }
    }
}
