using System.Threading.Tasks;

namespace SteffBeckers.Data;

public interface ISteffBeckersDbSchemaMigrator
{
    Task MigrateAsync();
}
