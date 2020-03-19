using System;
using EasyAbp.UniappManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.Uniapps
{
    public class UniappRepository : EfCoreRepository<UniappManagementDbContext, Uniapp, Guid>, IUniappRepository
    {
        public UniappRepository(IDbContextProvider<UniappManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}