using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.UniappVersions.Dtos
{
    public class UniappVersionDto : FullAuditedEntityDto<Guid>
    {
        public Guid AppId { get; set; }

        public long BuildNumber { get; set; }

        public string Tag { get; set; }

        public string WgtUrl { get; set; }

        public string PkgUrl { get; set; }

        public bool IsLatest { get; set; }
    }
}