using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.UniappVersions;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace EasyAbp.UniappManagement.EntityFrameworkCore.UniappVersions
{
    public class UniappVersionRepositoryTests : UniappManagementEntityFrameworkCoreTestBase
    {
        private readonly IRepository<UniappVersion, Guid> _uniappVersionRepository;

        public UniappVersionRepositoryTests()
        {
            _uniappVersionRepository = GetRequiredService<IRepository<UniappVersion, Guid>>();
        }

        [Fact]
        public async Task Test1()
        {
            await WithUnitOfWorkAsync(async () =>
            {
                // Arrange

                // Act

                //Assert
            });
        }
    }
}
