using EasyAbp.UniappManagement.Localization;
using Volo.Abp.Application.Services;

namespace EasyAbp.UniappManagement
{
    public abstract class UniappManagementAppService : ApplicationService
    {
        protected UniappManagementAppService()
        {
            LocalizationResource = typeof(UniappManagementResource);
            ObjectMapperContext = typeof(UniappManagementApplicationModule);
        }
    }
}
