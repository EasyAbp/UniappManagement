using System;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.UniappManagement.Uniapps
{
    public interface IUniappAppService :
        ICrudAppService< 
            UniappDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateUniappDto,
            CreateUpdateUniappDto>
    {

    }
}