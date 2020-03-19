using System;
using System.Linq;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.Authorization;
using EasyAbp.UniappManagement.Uniapps;
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

        private readonly IUniappRepository _uniappRepository;
        private readonly IUniappVersionRepository _uniappVersionRepository;

        public UniappVersionAppService(
            IUniappRepository uniappRepository,
            IUniappVersionRepository uniappVersionRepository) : base(uniappVersionRepository)
        {
            _uniappRepository = uniappRepository;
            _uniappVersionRepository = uniappVersionRepository;
        }

        protected override IQueryable<UniappVersion> CreateFilteredQuery(UniappVersionGetListDto input)
        {
            return base.CreateFilteredQuery(input).Where(v => v.AppId == input.AppId);
        }

        public async Task<UniappVersionDto> GetPublicLatestAsync(Guid id)
        {
            var version = await _uniappVersionRepository.GetLatestByAppIdAsync(id);

            return ObjectMapper.Map<UniappVersion, UniappVersionDto>(version);
        }

        public async Task<UniappVersionDto> GetPublicLatestByAppNameAsync(string name)
        {
            var uniapp = await _uniappRepository.FindByNameAsync(name);

            if (uniapp == null)
            {
                throw new UniappNotFoundException(name);
            }

            return await GetPublicLatestAsync(uniapp.Id);
        }
        
        public async Task<UniappVersionDto> GetPublicAsync(Guid id, string tag)
        {
            var version = await _uniappVersionRepository.GetByAppIdAsync(id, tag);

            return ObjectMapper.Map<UniappVersion, UniappVersionDto>(version);
        }

        public async Task<UniappVersionDto> GetPublicByAppNameAsync(string name, string tag)
        {
            var uniapp = await _uniappRepository.FindByNameAsync(name);

            if (uniapp == null)
            {
                throw new UniappNotFoundException(name);
            }

            return await GetPublicAsync(uniapp.Id, tag);
        }
    }
}