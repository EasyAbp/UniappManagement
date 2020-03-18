using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace EasyAbp.UniappManagement.MongoDB
{
    [ConnectionStringName(UniappManagementDbProperties.ConnectionStringName)]
    public interface IUniappManagementMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
