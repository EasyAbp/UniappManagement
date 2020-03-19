using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using EasyAbp.UniappManagement.Uniapps;
using EasyAbp.UniappManagement.UniappVersions;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    [ConnectionStringName(UniappManagementDbProperties.ConnectionStringName)]
    public class UniappManagementDbContext : AbpDbContext<UniappManagementDbContext>, IUniappManagementDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Uniapp> Uniapps { get; set; }
        public DbSet<UniappVersion> UniappVersions { get; set; }

        public UniappManagementDbContext(DbContextOptions<UniappManagementDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUniappManagement();
        }
    }
}
