using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace EasyAbp.UniappManagement.Uniapps
{
    public class UniappRepository : EfCoreRepository<UniappManagementDbContext, Uniapp, Guid>, IUniappRepository
    {
        public UniappRepository(IDbContextProvider<UniappManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public virtual async Task<Uniapp> FindByNameAsync(string name, CancellationToken cancellationToken = default)
        {
            return await GetQueryable().Where(app => app.Name == name.Trim() && app.IsAvailable)
                .FirstOrDefaultAsync(cancellationToken: cancellationToken);
        }
    }
}