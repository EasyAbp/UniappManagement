using System;
using System.Threading;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.UniappManagement.Uniapps
{
    public interface IUniappRepository : IRepository<Uniapp, Guid>
    {
        Task<Uniapp> FindByNameAsync(string name, CancellationToken cancellationToken = default);
    }
}