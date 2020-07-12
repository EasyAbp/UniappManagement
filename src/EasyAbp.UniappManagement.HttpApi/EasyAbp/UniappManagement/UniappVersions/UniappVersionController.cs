using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.UniappVersions
{
    [RemoteService(Name = "EasyAbpUniappManagement")]
    [Route("/api/uniappManagement/uniappVersion")]
    public class UniappVersionController : UniappManagementController, IUniappVersionAppService
    {
        private readonly IUniappVersionAppService _service;

        public UniappVersionController(IUniappVersionAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public Task<UniappVersionDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public Task<PagedResultDto<UniappVersionDto>> GetListAsync(UniappVersionGetListDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public Task<UniappVersionDto> CreateAsync(CreateUpdateUniappVersionDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public Task<UniappVersionDto> UpdateAsync(Guid id, CreateUpdateUniappVersionDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }

        [HttpGet]
        [Route("publicLatest/{appId}")]
        public Task<UniappVersionDto> GetPublicLatestAsync(Guid appId)
        {
            return _service.GetPublicLatestAsync(appId);
        }

        [HttpGet]
        [Route("publicLatestByAppName")]
        public Task<UniappVersionDto> GetPublicLatestByAppNameAsync(string name)
        {
            return _service.GetPublicLatestByAppNameAsync(name);
        }

        [HttpGet]
        [Route("public/{appId}")]
        public Task<UniappVersionDto> GetPublicAsync(Guid appId, string tag)
        {
            return _service.GetPublicAsync(appId, tag);
        }

        [HttpGet]
        [Route("publicByAppName")]
        public Task<UniappVersionDto> GetPublicByAppNameAsync(string name, string tag)
        {
            return _service.GetPublicByAppNameAsync(name, tag);
        }
    }
}