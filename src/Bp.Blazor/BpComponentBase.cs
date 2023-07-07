using Bp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Bp.Blazor;

public abstract class BpComponentBase : AbpComponentBase
{
    protected BpComponentBase()
    {
        LocalizationResource = typeof(BpResource);
    }
}
