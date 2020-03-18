using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace EasyAbp.UniappManagement
{
    [Dependency(ReplaceServices = true)]
    public class UniappManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UniappManagement";
    }
}
