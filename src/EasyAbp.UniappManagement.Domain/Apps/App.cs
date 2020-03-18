using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.UniappManagement.Apps
{
    public class App : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }
        
        [NotNull]
        public virtual string Name { get; protected set; }
        
        [CanBeNull]
        public virtual string Description { get; protected set; }
        
        [CanBeNull]
        public virtual string IconImageUrl { get; protected set; }
        
        public virtual bool IsAvailable { get; protected set; }
        
        protected App() { }

        public App(
            Guid id,
            Guid? tenantId,
            [NotNull] string name,
            [CanBeNull] string description,
            [CanBeNull] string iconImageUrl,
            bool isAvailable) : base(id)
        {
            TenantId = tenantId;
            Name = name;
            Description = description;
            IconImageUrl = iconImageUrl;
            IsAvailable = isAvailable;
        }
    }
}