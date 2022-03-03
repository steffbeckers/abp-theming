using SteffBeckers.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace SteffBeckers;

[DependsOn(
    typeof(SteffBeckersEntityFrameworkCoreTestModule)
    )]
public class SteffBeckersDomainTestModule : AbpModule
{

}
