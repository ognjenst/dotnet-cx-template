using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Server.Persistance.Utilities
{
	public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Database");
            if (connectionString == null)
                throw new Exception("Connection string not found.");

            // Uncoment this line for PostgreSQL or change it for other DBs
            //services.AddDbContext<ServerDbContext>(options => options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention());
            services.AddScoped<ServerDbContext>();
            return services;
        }
    }
}

