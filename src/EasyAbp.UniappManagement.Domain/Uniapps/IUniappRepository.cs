using System;
using Volo.Abp.Domain.Repositories;

namespace EasyAbp.UniappManagement.Uniapps
{
    public interface IUniappRepository : IRepository<Uniapp, Guid>
    {
    }
}