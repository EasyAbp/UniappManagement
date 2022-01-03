using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace EasyAbp.UniappManagement.Uniapps
{
    [RemoteService(Name = UniappManagementRemoteServiceConsts.RemoteServiceName)]
    [Route("/api/uniapp-management/uniapp")]
    public class UniappController : UniappManagementController, IUniappAppService
    {
        private readonly IUniappAppService _service;

        public UniappController(IUniappAppService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("{id}")]
        public virtual Task<UniappDto> GetAsync(Guid id)
        {
            return _service.GetAsync(id);
        }

        [HttpGet]
        public virtual Task<PagedResultDto<UniappDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return _service.GetListAsync(input);
        }

        [HttpPost]
        public virtual Task<UniappDto> CreateAsync(CreateUpdateUniappDto input)
        {
            return _service.CreateAsync(input);
        }

        [HttpPut]
        [Route("{id}")]
        public virtual Task<UniappDto> UpdateAsync(Guid id, CreateUpdateUniappDto input)
        {
            return _service.UpdateAsync(id, input);
        }

        [HttpDelete]
        [Route("{id}")]
        public virtual Task DeleteAsync(Guid id)
        {
            return _service.DeleteAsync(id);
        }
    }
}