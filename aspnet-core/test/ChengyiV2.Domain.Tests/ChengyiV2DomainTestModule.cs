using ChengyiV2.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ChengyiV2;

[DependsOn(
    typeof(ChengyiV2EntityFrameworkCoreTestModule)
    )]
public class ChengyiV2DomainTestModule : AbpModule
{

}
