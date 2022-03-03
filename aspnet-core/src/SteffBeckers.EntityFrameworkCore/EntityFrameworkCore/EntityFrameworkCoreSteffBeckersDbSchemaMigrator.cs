using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SteffBeckers.Data;
using Volo.Abp.DependencyInjection;

namespace SteffBeckers.EntityFrameworkCore;

public class EntityFrameworkCoreSteffBeckersDbSchemaMigrator
    : ISteffBeckersDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreSteffBeckersDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the SteffBeckersDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<SteffBeckersDbContext>()
            .Database
            .MigrateAsync();
    }
}
