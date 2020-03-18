using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    public class UniappManagementHttpApiHostMigrationsDbContext : AbpDbContext<UniappManagementHttpApiHostMigrationsDbContext>
    {
        public UniappManagementHttpApiHostMigrationsDbContext(DbContextOptions<UniappManagementHttpApiHostMigrationsDbContext> options)
            : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureUniappManagement();
        }
    }
}
