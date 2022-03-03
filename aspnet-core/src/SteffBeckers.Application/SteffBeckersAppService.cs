using System;
using System.Collections.Generic;
using System.Text;
using SteffBeckers.Localization;
using Volo.Abp.Application.Services;

namespace SteffBeckers;

/* Inherit your application services from this class.
 */
public abstract class SteffBeckersAppService : ApplicationService
{
    protected SteffBeckersAppService()
    {
        LocalizationResource = typeof(SteffBeckersResource);
    }
}
