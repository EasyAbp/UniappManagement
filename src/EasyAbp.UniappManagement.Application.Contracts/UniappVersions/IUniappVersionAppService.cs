using System;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public interface IUniappVersionAppService :
        ICrudAppService< 
            UniappVersionDto, 
            Guid, 
            UniappVersionGetListDto,
            CreateUpdateUniappVersionDto,
            CreateUpdateUniappVersionDto>
    {

    }
}