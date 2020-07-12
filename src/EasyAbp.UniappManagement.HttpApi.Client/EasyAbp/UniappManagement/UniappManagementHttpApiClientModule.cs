using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UniappManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "EasyAbpUniappManagement";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UniappManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
