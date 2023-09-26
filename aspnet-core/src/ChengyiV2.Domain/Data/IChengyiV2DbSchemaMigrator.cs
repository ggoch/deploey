using System.Threading.Tasks;

namespace ChengyiV2.Data;

public interface IChengyiV2DbSchemaMigrator
{
    Task MigrateAsync();
}
