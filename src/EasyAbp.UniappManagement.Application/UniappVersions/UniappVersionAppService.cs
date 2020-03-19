using System;
using System.Linq;
using EasyAbp.UniappManagement.Authorization;
using EasyAbp.UniappManagement.UniappVersions.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappVersionAppService : CrudAppService<UniappVersion, UniappVersionDto, Guid, UniappVersionGetListDto, CreateUpdateUniappVersionDto, CreateUpdateUniappVersionDto>,
        IUniappVersionAppService
    {
        protected override string CreatePolicyName { get; set; } = UniappManagementPermissions.UniappVersions.Create;
        protected override string DeletePolicyName { get; set; } = UniappManagementPermissions.UniappVersions.Default;
        protected override string UpdatePolicyName { get; set; } = UniappManagementPermissions.UniappVersions.Update;
        protected override string GetPolicyName { get; set; } = UniappManagementPermissions.UniappVersions.Default;
        protected override string GetListPolicyName { get; set; } = UniappManagementPermissions.UniappVersions.Default;
        
        private readonly IUniappVersionRepository _repository;

        public UniappVersionAppService(IUniappVersionRepository repository) : base(repository)
        {
            _repository = repository;
        }

        protected override IQueryable<UniappVersion> CreateFilteredQuery(UniappVersionGetListDto input)
        {
            return base.CreateFilteredQuery(input).Where(v => v.AppId == input.AppId);
        }
    }
}