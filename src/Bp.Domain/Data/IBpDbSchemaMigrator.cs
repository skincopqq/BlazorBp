using System.Threading.Tasks;

namespace Bp.Data;

public interface IBpDbSchemaMigrator
{
    Task MigrateAsync();
}
