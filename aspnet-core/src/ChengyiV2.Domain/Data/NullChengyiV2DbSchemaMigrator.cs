using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ChengyiV2.Data;

/* This is used if database provider does't define
 * IChengyiV2DbSchemaMigrator implementation.
 */
public class NullChengyiV2DbSchemaMigrator : IChengyiV2DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
