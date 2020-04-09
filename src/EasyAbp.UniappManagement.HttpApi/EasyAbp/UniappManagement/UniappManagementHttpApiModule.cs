using Localization.Resources.AbpUi;
using EasyAbp.UniappManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(UniappManagementApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UniappManagementHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UniappManagementHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UniappManagementResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
