using ChengyiV2.Localization;
using Volo.Abp.Application.Services;

namespace ChengyiV2;

/* Inherit your application services from this class.
 */
public abstract class ChengyiV2AppService : ApplicationService
{
    protected ChengyiV2AppService()
    {
        LocalizationResource = typeof(ChengyiV2Resource);
    }
}
