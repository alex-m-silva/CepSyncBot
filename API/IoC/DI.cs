using Application.Services;
using Domain.Iterfaces.Repositories;
using Domain.Iterfaces.Services;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.IoC
{
    public static class DI
    {
        public static void AddSdk(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
