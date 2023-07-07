using Volo.Abp.Settings;

namespace Bp.Settings;

public class BpSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BpSettings.MySetting1));
    }
}
