using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementDomainSharedModule)
        )]
    public class UniappManagementDomainModule : AbpModule
    {

    }
}
