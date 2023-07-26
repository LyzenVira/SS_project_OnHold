using Identity.Domain.Entities;
using Identity.Infrastructure.DataAccess;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Identity.WebApi
{
    public class Startup
    {
        private IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddIdentityCore<AppUser>()
           .AddRoles<IdentityRole<Guid>>()
           .AddEntityFrameworkStores<DatabaseContext>()
           .AddDefaultTokenProviders();

            services.AddDbContext<DatabaseContext>(configurations => {
                configurations.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
                });

            /*services.AddIdentityCore<IdentityUser<Guid>>()
            .AddRoles<IdentityRole<Guid>>()
            .AddSignInManager<SignInManager<IdentityUser<Guid>>>()
            .AddEntityFrameworkStores<DatabaseContext>()
            .AddDefaultTokenProviders();*/

           

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(options => { options.SwaggerEndpoint("/swagger/v1/swagger.json", "CSV File Editor"); });
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
        }
    }
}
