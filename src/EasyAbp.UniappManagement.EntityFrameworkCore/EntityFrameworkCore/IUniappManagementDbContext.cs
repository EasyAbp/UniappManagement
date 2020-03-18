using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    [ConnectionStringName(UniappManagementDbProperties.ConnectionStringName)]
    public interface IUniappManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}