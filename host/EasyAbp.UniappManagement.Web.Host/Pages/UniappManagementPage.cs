using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace EasyAbp.UniappManagement.Pages
{
    public abstract class UniappManagementPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<UniappManagementResource> L { get; set; }
    }
}
