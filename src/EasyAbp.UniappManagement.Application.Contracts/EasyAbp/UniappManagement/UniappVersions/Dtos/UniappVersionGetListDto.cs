using System;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.UniappVersions.Dtos
{
    public class UniappVersionGetListDto : PagedAndSortedResultRequestDto
    {
        public Guid AppId { get; set; }
    }
}