using System;
using Volo.Abp;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement.MongoDB
{
    [DependsOn(
        typeof(UniappManagementTestBaseModule),
        typeof(UniappManagementMongoDbModule)
        )]
    public class UniappManagementMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
            });
        }
    }
}