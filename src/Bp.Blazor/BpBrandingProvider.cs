using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Bp.Blazor;

[Dependency(ReplaceServices = true)]
public class BpBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Bp";
}
