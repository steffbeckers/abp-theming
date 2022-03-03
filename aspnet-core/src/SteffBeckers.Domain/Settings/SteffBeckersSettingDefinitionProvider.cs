using Volo.Abp.Settings;

namespace SteffBeckers.Settings;

public class SteffBeckersSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SteffBeckersSettings.MySetting1));
    }
}
