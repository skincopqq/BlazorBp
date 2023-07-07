using System;
using System.Collections.Generic;
using System.Text;
using Bp.Localization;
using Volo.Abp.Application.Services;

namespace Bp;

/* Inherit your application services from this class.
 */
public abstract class BpAppService : ApplicationService
{
    protected BpAppService()
    {
        LocalizationResource = typeof(BpResource);
    }
}
