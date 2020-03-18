using EasyAbp.UniappManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace EasyAbp.UniappManagement
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(UniappManagementEntityFrameworkCoreTestModule)
        )]
    public class UniappManagementDomainTestModule : AbpModule
    {
        
    }
}
