using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace EasyAbp.UniappManagement.EntityFrameworkCore
{
    public static class UniappManagementDbContextModelCreatingExtensions
    {
        public static void ConfigureUniappManagement(
            this ModelBuilder builder,
            Action<UniappManagementModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UniappManagementModelBuilderConfigurationOptions(
                UniappManagementDbProperties.DbTablePrefix,
                UniappManagementDbProperties.DbSchema
            );

            optionsAction?.Invoke(options);

            /* Configure all entities here. Example:

            builder.Entity<Question>(b =>
            {
                //Configure table & schema name
                b.ToTable(options.TablePrefix + "Questions", options.Schema);
            
                b.ConfigureFullAuditedAggregateRoot();
            
                //Properties
                b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);
                
                //Relations
                b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

                //Indexes
                b.HasIndex(q => q.CreationTime);
            });
            */
        }
    }
}