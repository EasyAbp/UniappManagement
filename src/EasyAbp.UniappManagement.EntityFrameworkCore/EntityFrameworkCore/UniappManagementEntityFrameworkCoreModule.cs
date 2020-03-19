using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.Uniapps;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    [DependsOn(
        typeof(UniappManagementDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class UniappManagementEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<UniappManagementDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<Uniapp, UniappRepository>();
                options.AddRepository<UniappVersion, UniappVersionRepository>();
            });
        }
    }
}
