using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.UniappManagement.MongoDB
{
    [ConnectionStringName(UniappManagementDbProperties.ConnectionStringName)]
    public class UniappManagementMongoDbContext : AbpMongoDbContext, IUniappManagementMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUniappManagement();
        }
    }
}