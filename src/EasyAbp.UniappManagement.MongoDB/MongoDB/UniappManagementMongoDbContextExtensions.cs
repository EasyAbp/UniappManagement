using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace EasyAbp.UniappManagement.MongoDB
{
    public static class UniappManagementMongoDbContextExtensions
    {
        public static void ConfigureUniappManagement(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UniappManagementMongoModelBuilderConfigurationOptions(
                UniappManagementDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}