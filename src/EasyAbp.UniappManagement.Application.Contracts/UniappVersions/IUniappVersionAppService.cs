using System;
using System.Threading.Tasks;
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
        Task<UniappVersionDto> GetPublicLatestAsync(Guid id);
        
        Task<UniappVersionDto> GetPublicLatestByAppNameAsync(string name);
        
        Task<UniappVersionDto> GetPublicAsync(Guid id, string tag);
        
        Task<UniappVersionDto> GetPublicByAppNameAsync(string name, string tag);
    }
}