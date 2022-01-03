using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UniappManagementHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = UniappManagementRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UniappManagementApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UniappManagementHttpApiClientModule>();
            });
        }
    }
}
