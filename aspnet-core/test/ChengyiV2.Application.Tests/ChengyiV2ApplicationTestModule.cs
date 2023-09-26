using Volo.Abp.Modularity;

namespace ChengyiV2;

[DependsOn(
    typeof(ChengyiV2ApplicationModule),
    typeof(ChengyiV2DomainTestModule)
    )]
public class ChengyiV2ApplicationTestModule : AbpModule
{

}
