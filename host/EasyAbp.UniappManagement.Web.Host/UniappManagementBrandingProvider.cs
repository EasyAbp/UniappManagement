using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace EasyAbp.UniappManagement
{
    [Dependency(ReplaceServices = true)]
    public class UniappManagementBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UniappManagement";
    }
}
