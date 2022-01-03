using EasyAbp.UniappManagement.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement
{
    [Area(UniappManagementRemoteServiceConsts.ModuleName)]
    public abstract class UniappManagementController : AbpControllerBase
    {
        protected UniappManagementController()
        {
            LocalizationResource = typeof(UniappManagementResource);
        }
    }
}
