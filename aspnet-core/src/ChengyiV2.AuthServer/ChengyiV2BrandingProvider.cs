using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ChengyiV2;

[Dependency(ReplaceServices = true)]
public class ChengyiV2BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ChengyiV2";
}
