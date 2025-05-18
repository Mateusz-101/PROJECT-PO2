using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace OSPManagementSystem.Data
{
    public class OSPContextFactory : IDesignTimeDbContextFactory<OSPContext>
    {
        public OSPContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<OSPContext>();

            // Wczytanie appsettings.json ręcznie
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("OSPContext");
            optionsBuilder.UseSqlServer(connectionString);

            return new OSPContext(optionsBuilder.Options);
        }
    }
}
