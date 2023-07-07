using Bp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Bp.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(BpEntityFrameworkCoreModule),
    typeof(BpApplicationContractsModule)
    )]
public class BpDbMigratorModule : AbpModule
{

}
