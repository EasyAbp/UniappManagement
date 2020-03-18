using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace EasyAbp.UniappManagement
{
    public abstract class UniappManagementController : AbpController
    {
        protected UniappManagementController()
        {
            LocalizationResource = typeof(UniappManagementResource);
        }
    }
}
