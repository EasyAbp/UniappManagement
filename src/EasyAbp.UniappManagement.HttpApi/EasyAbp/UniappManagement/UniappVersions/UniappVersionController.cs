using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.UniappVersions
{
    [RemoteService(Name = UniappManagementRemoteServiceConsts.RemoteServiceName)]
    [Route("/api/uniapp-management/uniapp-version")]
    public class UniappVersionController : UniappManagementController, IUniappVersionAppService
    {
        private readonly IUniappVersionAppService _service;

        public UniappVersionController(IUniappVersionAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<UniappVersionDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<UniappVersionDto>> GetListAsync(UniappVersionGetListDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public virtual Task<UniappVersionDto> CreateAsync(CreateUpdateUniappVersionDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<UniappVersionDto> UpdateAsync(Guid id, CreateUpdateUniappVersionDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("public-latest/{appId}")]
        public virtual Task<UniappVersionDto> GetPublicLatestAsync(Guid appId)
        {
            return _service.GetPublicLatestAsync(appId);
        }

        [HttpGet]
        [Route("public-latest/by-app-name/{name}")]
        public virtual Task<UniappVersionDto> GetPublicLatestByAppNameAsync(string name)
        {
            return _service.GetPublicLatestByAppNameAsync(name);
        }

        [HttpGet]
        [Route("public/{appId}")]
        public virtual Task<UniappVersionDto> GetPublicAsync(Guid appId, string tag)
        {
            return _service.GetPublicAsync(appId, tag);
        }

        [HttpGet]
        [Route("public/by-app-name/{name}/{tag}")]
        public virtual Task<UniappVersionDto> GetPublicByAppNameAsync(string name, string tag)
        {
            return _service.GetPublicByAppNameAsync(name, tag);
        }
    }
}