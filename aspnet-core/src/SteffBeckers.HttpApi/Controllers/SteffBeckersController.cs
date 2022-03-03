using SteffBeckers.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace SteffBeckers.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SteffBeckersController : AbpControllerBase
{
    protected SteffBeckersController()
    {
        LocalizationResource = typeof(SteffBeckersResource);
    }
}
