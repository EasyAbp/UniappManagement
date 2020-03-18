using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using EasyAbp.UniappManagement.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Validation;
using Volo.Abp.Validation.Localization;
using Volo.Abp.VirtualFileSystem;

namespace EasyAbp.UniappManagement
{
    [DependsOn(
        typeof(AbpValidationModule)
    )]
    public class UniappManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UniappManagementDomainSharedModule>("EasyAbp.UniappManagement");
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<UniappManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/UniappManagement");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("UniappManagement", typeof(UniappManagementResource));
            });
        }
    }
}
