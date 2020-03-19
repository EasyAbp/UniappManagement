using EasyAbp.UniappManagement.UniappVersions;
using EasyAbp.UniappManagement.Uniapps;
using System;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

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

            builder.Entity<Uniapp>(b =>
            {
                b.ToTable(options.TablePrefix + "Uniapps", options.Schema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
                b.HasIndex(u => u.Name);
            });

            builder.Entity<UniappVersion>(b =>
            {
                b.ToTable(options.TablePrefix + "UniappVersions", options.Schema);
                b.ConfigureByConvention(); 
                /* Configure more properties here */
                b.HasIndex(v => v.AppId);
            });
        }
    }
}
