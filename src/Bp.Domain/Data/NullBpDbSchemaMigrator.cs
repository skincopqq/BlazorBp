using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Bp.Data;

/* This is used if database provider does't define
 * IBpDbSchemaMigrator implementation.
 */
public class NullBpDbSchemaMigrator : IBpDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
