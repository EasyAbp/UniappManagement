using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    public class UniappManagementModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UniappManagementModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}