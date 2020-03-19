using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappVersionRepository : EfCoreRepository<UniappManagementDbContext, UniappVersion, Guid>, IUniappVersionRepository
    {
        public UniappVersionRepository(IDbContextProvider<UniappManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<UniappVersion> GetLatestByAppIdAsync(Guid appId, CancellationToken cancellationToken = default)
        {
            var entity = await GetQueryable().Where(v => v.AppId == appId).OrderByDescending(v => v.BuildNumber)
                .FirstOrDefaultAsync(cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(UniappVersion));
            }

            return entity;
        }

        public async Task<UniappVersion> GetByAppIdAsync(Guid appId, string tag, CancellationToken cancellationToken = default)
        {
            var entity = await GetQueryable()
                .FirstOrDefaultAsync(v => v.AppId == appId && v.Tag == tag.Trim(),
                    cancellationToken: cancellationToken);

            if (entity == null)
            {
                throw new EntityNotFoundException(typeof(UniappVersion));
            }

            return entity;
        }
    }
}