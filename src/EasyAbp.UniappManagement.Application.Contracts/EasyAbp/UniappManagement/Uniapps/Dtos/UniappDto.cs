using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.Uniapps.Dtos
{
    public class UniappDto : FullAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string IconImageUrl { get; set; }

        public bool IsAvailable { get; set; }
    }
}