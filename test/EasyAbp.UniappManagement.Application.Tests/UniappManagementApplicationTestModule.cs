using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementApplicationModule),
        typeof(UniappManagementDomainTestModule)
        )]
    public class UniappManagementApplicationTestModule : AbpModule
    {

    }
}
