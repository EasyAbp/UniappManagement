using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.UniappManagement.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UniappManagementPageModel : AbpPageModel
    {
        protected UniappManagementPageModel()
        {
            LocalizationResourceType = typeof(UniappManagementResource);
            ObjectMapperContext = typeof(UniappManagementWebModule);
        }
    }
}