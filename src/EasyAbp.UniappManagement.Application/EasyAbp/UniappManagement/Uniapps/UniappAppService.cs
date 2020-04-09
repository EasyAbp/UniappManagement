using System;
using EasyAbp.UniappManagement.Authorization;
using EasyAbp.UniappManagement.Uniapps.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.UniappManagement.Uniapps
{
    public class UniappAppService : CrudAppService<Uniapp, UniappDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUniappDto, CreateUpdateUniappDto>,
        IUniappAppService
    {
        protected override string CreatePolicyName { get; set; } = UniappManagementPermissions.Uniapps.Create;
        protected override string DeletePolicyName { get; set; } = UniappManagementPermissions.Uniapps.Delete;
        protected override string UpdatePolicyName { get; set; } = UniappManagementPermissions.Uniapps.Update;
        protected override string GetPolicyName { get; set; } = UniappManagementPermissions.Uniapps.Default;
        protected override string GetListPolicyName { get; set; } = UniappManagementPermissions.Uniapps.Default;
            
        private readonly IUniappRepository _repository;

        public UniappAppService(IUniappRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}