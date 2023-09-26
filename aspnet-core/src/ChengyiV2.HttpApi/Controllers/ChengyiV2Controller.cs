using ChengyiV2.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ChengyiV2.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ChengyiV2Controller : AbpControllerBase
{
    protected ChengyiV2Controller()
    {
        LocalizationResource = typeof(ChengyiV2Resource);
    }
}
