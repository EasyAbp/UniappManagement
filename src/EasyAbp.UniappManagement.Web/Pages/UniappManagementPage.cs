using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.UniappManagement.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits EasyAbp.UniappManagement.Web.Pages.UniappManagementPage
     */
    public abstract class UniappManagementPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UniappManagementResource> L { get; set; }
    }
}
