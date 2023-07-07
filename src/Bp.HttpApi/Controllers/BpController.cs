using Bp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Bp.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class BpController : AbpControllerBase
{
    protected BpController()
    {
        LocalizationResource = typeof(BpResource);
    }
}
