using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SteffBeckers.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SteffBeckersDbContextFactory : IDesignTimeDbContextFactory<SteffBeckersDbContext>
{
    public SteffBeckersDbContext CreateDbContext(string[] args)
    {
        SteffBeckersEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SteffBeckersDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SteffBeckersDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../SteffBeckers.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
