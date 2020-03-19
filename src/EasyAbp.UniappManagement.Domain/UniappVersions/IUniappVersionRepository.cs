using System;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.UniappManagement.UniappVersions
{
    public interface IUniappVersionRepository : IRepository<UniappVersion, Guid>
    {
    }
}