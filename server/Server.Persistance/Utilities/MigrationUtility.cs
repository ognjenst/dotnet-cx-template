using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace Server.Persistance.Utilities
{
	public static class MigrationUtility
	{

        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ServerDbContext>();
                context.Database.Migrate();
            }
        }
    }
}

