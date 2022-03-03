using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace SteffBeckers;

[Dependency(ReplaceServices = true)]
public class SteffBeckersBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "SteffBeckers";
}
