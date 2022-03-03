using Volo.Abp.Modularity;

namespace SteffBeckers;

[DependsOn(
    typeof(SteffBeckersApplicationModule),
    typeof(SteffBeckersDomainTestModule)
    )]
public class SteffBeckersApplicationTestModule : AbpModule
{

}
