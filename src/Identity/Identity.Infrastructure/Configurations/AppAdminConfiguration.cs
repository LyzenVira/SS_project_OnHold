using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Infrastructure.Configurations
{
    internal class AppAdminConfiguration : IEntityTypeConfiguration<AppAdmin>
    {
        public void Configure(EntityTypeBuilder<AppAdmin> builder)
        {
            builder.ToTable("AppAdmin");

            PasswordHasher<AppUser> hasher = new PasswordHasher<AppUser>();

            builder.HasData(new AppAdmin
            {
                Id = Guid.Parse("bebdddb7-27ab-4513-8ba7-a3eefcc7772b"),
                UserName = "Dmytro",
                Email = "assistant.dmytro@gmail.com",
                EmailConfirmed = true,
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumberConfirmed = true,
                Status = "Admin",
                PasswordHash = hasher.HashPassword(null, "Admin_1")
            });
        }
    }
}
