using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappVersion : FullAuditedAggregateRoot<Guid>, IMultiTenant
    {
        public virtual Guid? TenantId { get; protected set; }
        
        public virtual Guid AppId { get; protected set; }
        
        public virtual long BuildNumber { get; protected set; }

        [NotNull]
        public virtual string Tag { get; protected set; }

        [CanBeNull]
        public virtual string WgtUrl { get; protected set; }
        
        [CanBeNull]
        public virtual string PkgUrl { get; protected set; }
        
        protected UniappVersion() { }

        public UniappVersion(
            Guid id,
            Guid? tenantId,
            Guid appId,
            long buildNumber,
            [NotNull] string tag,
            [CanBeNull] string wgtUrl,
            [CanBeNull] string pkgUrl) : base(id)
        {
            TenantId = tenantId;
            AppId = appId;
            BuildNumber = buildNumber;
            Tag = tag;
            WgtUrl = wgtUrl;
            PkgUrl = pkgUrl;
        }
    }
}