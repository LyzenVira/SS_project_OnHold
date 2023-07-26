using Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Identity.Infrastructure.DataAccess
{
    public class DatabaseContext : IdentityDbContext<IdentityUser<Guid>,IdentityRole<Guid>, Guid>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options){        }

        public DbSet<AppUser> AspNetUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetAssembly(typeof(DatabaseContext))!);
        }
    }
}
