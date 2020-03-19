using System;
using System.Threading.Tasks;
using EasyAbp.UniappManagement.Uniapps;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace EasyAbp.UniappManagement.EntityFrameworkCore.Uniapps
{
    public class UniappRepositoryTests : UniappManagementEntityFrameworkCoreTestBase
    {
        private readonly IRepository<Uniapp, Guid> _uniappRepository;

        public UniappRepositoryTests()
        {
            _uniappRepository = GetRequiredService<IRepository<Uniapp, Guid>>();
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
