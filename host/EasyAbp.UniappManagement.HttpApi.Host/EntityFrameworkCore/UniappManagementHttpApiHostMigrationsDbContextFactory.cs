using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    public class UniappManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UniappManagementHttpApiHostMigrationsDbContext>
    {
        public UniappManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UniappManagementHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("UniappManagement"));

            return new UniappManagementHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
