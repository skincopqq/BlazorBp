using Volo.Abp.Modularity;

namespace Bp;

[DependsOn(
    typeof(BpApplicationModule),
    typeof(BpDomainTestModule)
    )]
public class BpApplicationTestModule : AbpModule
{

}
