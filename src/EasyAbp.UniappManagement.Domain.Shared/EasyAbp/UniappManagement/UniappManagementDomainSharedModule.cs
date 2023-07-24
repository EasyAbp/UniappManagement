using Volo.Abp.Domain;
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
        typeof(AbpValidationModule),
        typeof(AbpDddDomainSharedModule)
    )]
    public class UniappManagementDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<UniappManagementDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<UniappManagementResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/EasyAbp/UniappManagement/Localization/UniappManagement");
            });

            Configure<AbpExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("EasyAbp.UniappManagement", typeof(UniappManagementResource));
            });
        }
    }
}
