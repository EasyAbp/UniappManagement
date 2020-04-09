using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.UniappVersions;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    [ConnectionStringName(UniappManagementDbProperties.ConnectionStringName)]
    public interface IUniappManagementDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
        DbSet<Uniapp> Uniapps { get; set; }
        DbSet<UniappVersion> UniappVersions { get; set; }
    }
}
