using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace EasyAbp.UniappManagement.MongoDB
{
    public class UniappManagementMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UniappManagementMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}