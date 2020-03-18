using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.UniappManagement.Pages
{
    public abstract class UniappManagementPageModel : AbpPageModel
    {
        protected UniappManagementPageModel()
        {
            LocalizationResourceType = typeof(UniappManagementResource);
        }
    }
}