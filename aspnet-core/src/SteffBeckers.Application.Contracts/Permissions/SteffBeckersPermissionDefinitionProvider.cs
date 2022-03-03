using SteffBeckers.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace SteffBeckers.Permissions;

public class SteffBeckersPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(SteffBeckersPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(SteffBeckersPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<SteffBeckersResource>(name);
    }
}
