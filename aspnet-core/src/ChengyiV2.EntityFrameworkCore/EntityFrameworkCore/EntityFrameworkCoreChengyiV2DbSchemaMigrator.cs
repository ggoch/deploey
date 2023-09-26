using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ChengyiV2.Data;
using Volo.Abp.DependencyInjection;

namespace ChengyiV2.EntityFrameworkCore;

public class EntityFrameworkCoreChengyiV2DbSchemaMigrator
    : IChengyiV2DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreChengyiV2DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the ChengyiV2DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ChengyiV2DbContext>()
            .Database
            .MigrateAsync();
    }
}
