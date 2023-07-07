using Bp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Bp;

[DependsOn(
    typeof(BpEntityFrameworkCoreTestModule)
    )]
public class BpDomainTestModule : AbpModule
{

}
