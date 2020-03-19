using System;
using EasyAbp.UniappManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public class UniappVersionRepository : EfCoreRepository<UniappManagementDbContext, UniappVersion, Guid>, IUniappVersionRepository
    {
        public UniappVersionRepository(IDbContextProvider<UniappManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}