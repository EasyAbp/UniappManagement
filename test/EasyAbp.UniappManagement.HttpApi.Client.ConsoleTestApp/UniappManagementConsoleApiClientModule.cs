using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UniappManagementConsoleApiClientModule : AbpModule
    {
        
    }
}
