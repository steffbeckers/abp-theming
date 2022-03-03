using SteffBeckers.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace SteffBeckers.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SteffBeckersEntityFrameworkCoreModule),
    typeof(SteffBeckersApplicationContractsModule)
    )]
public class SteffBeckersDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
