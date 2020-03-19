using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public interface IUniappVersionRepository : IRepository<UniappVersion, Guid>
    {
        Task<UniappVersion> GetLatestByAppIdAsync(Guid appId, CancellationToken cancellationToken = default);
        
        Task<UniappVersion> GetByAppIdAsync(Guid appId, string tag, CancellationToken cancellationToken = default);
    }
}